namespace SafeAssignmentSystem.Core.Service
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.Common.Notification;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Data;
    using SafeAssignmentSystem.Core.Models.StatusModels;
    using SafeAssignmentSystem.Core.Models.TransferModels;
    using SafeAssignmentSystem.DataBase.Data.Common;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
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
        private readonly RoleManager<ApplicationRole> roleManager;
        private readonly IRepository repo;

        public AccountService(
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            IRepository repo)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.repo = repo;
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
    }
}


