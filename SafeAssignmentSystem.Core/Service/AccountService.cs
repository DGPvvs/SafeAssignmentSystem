namespace SafeAssignmentSystem.Core.Service
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.Common.Notification;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Data;
    using SafeAssignmentSystem.Core.Models.StatusModels;
    using SafeAssignmentSystem.Core.Models.TransferModels;
    using SafeAssignmentSystem.Core.Models.TransferModels.UserTransferModels;
    using SafeAssignmentSystem.DataBase.Data.Common;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.StaffsModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using static SafeAssignmentSystem.Common.Notification.NotificationConstants;
    using static SafeAssignmentSystem.Common.Notification.RoleConstants;

    public class AccountService : IAccountService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<ApplicationRole> roleManager;
        private readonly IRepository repo;

        public AccountService(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<ApplicationRole> roleManager,
            IRepository repo)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.repo = repo;
        }

        public async Task<IEnumerable<UserTransferModel>> GetAllUsers(string currentUserName)
        {            
            return await this.userManager.Users
                .Where(u => u.UserName != currentUserName)
                .Select(u => new UserTransferModel()
                {
                    UserName = u.UserName
                })
                .ToListAsync();
        }

        public async Task<StatusUserModel> LoginPermissionAsync(UserTransferModel user)
        {

            StatusUserModel result = new StatusUserModel()
            {
                Success = false,
                Description = User_Not_Permision_For_Work
            };

            var userPermis = await this.userManager.FindByNameAsync(user.UserName);

            if (userPermis is null)
            {
                result.Description = User_Not_Found;
                return result;
            }

            string userRole = new List<string>(await this.userManager.GetRolesAsync(userPermis)).First();

            if (userRole == Administrator)
            {
                result.Success = true;
                result.Description = User_Success;
                return result;
            }

            if (userRole == Operator || userRole == Electrician)
            {
                DateTime currentDateTime = DateTime.Now;
                DateTime date = currentDateTime.Date;
                InstantConstants time = new InstantConstants();

                var shifts = await this.repo.AllReadonly<ChangedSchedule>()
                    .Where(cs => cs.ApplicationUserId == userPermis.Id && cs.Date.Date == date)
                    .Select(cs => new UserShiftTransferModel()
                    {
                        Start = cs.Shift.StartTime,
                        End = cs.Shift.EndTime,
                        Date = cs.Date.Date
                    })
                    .ToListAsync();

                if (shifts.Count > 0)
                {
                    var shift = shifts.First();

                    var tSpan = shift.Start - time.referenceDateTime;
                    var startTime = shift.Date + tSpan;

                    tSpan = shift.End - time.referenceDateTime;
                    var endTime = shift.Date + tSpan;

                    if (currentDateTime >= startTime && currentDateTime <= endTime)
                    {
                        result.Success = true;
                        result.Description = User_Success;
                        return result;
                    }
                }
            }

            return result;
        }

        public async Task<StatusUserModel> RegisterUserAsync(RegisterUserTransferModel model)
        {
            StatusUserModel result = new StatusUserModel()
            {
                Success = false,
                Description = User_Registration_Fail
            };

            var user = await this.userManager.FindByNameAsync(model.UserName);

            if (!(user is null))
            {
                result.Description = User_Already_Exists;
                return result;
            }

            var duplicateNum = await this.userManager.Users.FirstOrDefaultAsync(u => u.UserWorkNumber == model.UserWorkNumber);

            if (!(duplicateNum is null))
            {
                result.Description = User_WorkNumber_Already_Exists;

                return result;
            }

            var newUser = new ApplicationUser()
            {
                UserName = model.UserName,
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserWorkNumber = model.UserWorkNumber
            };

            var createStatus = await this.userManager.CreateAsync(newUser, model.Password);

            user = await this.userManager.FindByNameAsync(model.UserName);

            var roleAddResult = await this.userManager.AddToRoleAsync(user, model.Role);

            if (!roleAddResult.Succeeded) 
            {
                await this.userManager.DeleteAsync(user);
                result.Description = User_Registration_Fail;

                return result;
            }

            foreach (var instalation in model.Instalations)
            {
                var inst = await this.repo.All<PlantInstalation>(pi => pi.Name == instalation).FirstAsync();

                ApplicationUserPlantInstalation applicationUserPlantInstalation = new ApplicationUserPlantInstalation()
                {
                    ApplicationUser = user,
                    Instalation = inst,
                    IsActive = true
                };

                await this.repo.AddAsync(applicationUserPlantInstalation);
                await this.repo.SaveChangesAsync();
            }

            result.Success = true;

            return result;
        }
    }
}


