﻿namespace SafeAssignmentSystem.Core.Service
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.Common.Notification;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Models.StatusModels;
    using SafeAssignmentSystem.Core.Models.TransferModels;
    using SafeAssignmentSystem.Core.Models.TransferModels.UserTransferModels;
    using SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels;
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

    /// <summary>
    /// Сървис манипулиращ данните при работа с акаунти на потребители
    /// </summary>
    public class AccountService : IAccountService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IRepository repo;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="repo"></param>
        public AccountService(
            UserManager<ApplicationUser> userManager,
            IRepository repo)
        {
            this.userManager = userManager;
            this.repo = repo;
        }


        /// <summary>
        /// Имплементация на метода за редактиране на потребителски акаунти 
        /// </summary>
        /// <param name="model">Трансферен модел</param>
        /// <param name="AdministratorUserName">Потребителско име на текущо логнатия администратор</param>
        /// <returns></returns>
        public async Task<StatusModel> EditAccount(RegisterUserTransferModel model, string AdministratorUserName)
        {
            StatusModel result = new StatusModel()
            {
                Success = false,
                Description = User_Edit_Account_Fail
            };

            var user = await this.userManager.FindByIdAsync(model.Id.ToString());

            if (user is null)
            {
                result.Description = User_Not_Registred;
                return result;
            }

            if (user.UserName == AdministratorUserName)
            {
                result.Description = User_Cant_Edit_Youself;
                return result;
            }

            var duplicateNum = await this.userManager.Users.FirstOrDefaultAsync(u => u.UserWorkNumber == model.UserWorkNumber);

            if ((!(duplicateNum is null)) && (duplicateNum.Id != user.Id))
            {
                result.Description = User_WorkNumber_Already_Exists;
                return result;
            }

            var duplicateUserName = await this.userManager.Users.FirstOrDefaultAsync(u => u.UserName == model.UserName);

            if ((!(duplicateUserName is null)) && (duplicateUserName.Id != user.Id))
            {
                result.Description = User_Already_Exists;
                return result;
            }

            user.UserName = model.UserName;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.UserWorkNumber = model.UserWorkNumber;
            user.ConcurrencyStamp = Guid.NewGuid().ToString();

            try
            {
                var roles = await this.userManager.GetRolesAsync(user);
                var role = roles.FirstOrDefault();

                var plantsPermis = await this.repo.All<ApplicationUserPlantInstalation>()
                    .Where(au => au.UserId == user.Id)
                    .ToListAsync();

                foreach (var plantPermis in plantsPermis)
                {
                    plantPermis.IsActive = false;
                }

                Queue<Guid> plantsIds = new Queue<Guid>(model.Instalations);

                List<ApplicationUserPlantInstalation> newPlantsPermis = new List<ApplicationUserPlantInstalation>();

                while (plantsIds.Count > 0)
                {
                    int index = 0;
                    bool isLoopExit = false;

                    Guid plantId = plantsIds.Dequeue();

                    while (!isLoopExit && index < plantsPermis.Count)
                    {
                        if (plantId == plantsPermis[index].InstalationId)
                        {
                            plantsPermis[index].IsActive = true;
                            isLoopExit = true;
                        }

                        index++;
                    }

                    if (!isLoopExit)
                    {
                        newPlantsPermis.Add(new ApplicationUserPlantInstalation()
                        {
                            UserId = user.Id,
                            ApplicationUser = user,
                            InstalationId = plantId,
                            IsActive = true
                        });
                    }
                }

                this.repo.UpdateRange<ApplicationUserPlantInstalation>(plantsPermis);

                if (!string.IsNullOrEmpty(role))
                {
                    await this.userManager.RemoveFromRoleAsync(user, role);
                }

                await this.userManager.AddToRoleAsync(user, model.Role);

                if (newPlantsPermis.Count > 0)
                {
                    await this.repo.AddRangeAsync(newPlantsPermis);
                }

                await this.repo.SaveChangesAsync();

                result.Success = true;
                result.Description = User_Edit_Account_Success;
            }
            catch (Exception)
            {
                result.Description = User_Edit_Account_Fail;
            }

            return result;
        }

        /// <summary>
        /// Метод връщащ колекция от данните за всички регистрирани
        /// потребители с изключение на потребителя currentUserName 
        /// </summary>
        /// <param name="currentUserName">Име на потребител, който няма да бъде включен във върнатата колекция</param>
        /// <returns></returns>
        public async Task<IEnumerable<UserTransferModel>> GetAllUsers(string currentUserName)
        {
            return await this.userManager.Users
                .Where(u => u.UserName != currentUserName)
                .Select(u => new UserTransferModel()
                {
                    UserName = u.UserName,
                    FirstName = u.FirstName,
                    LastName = u.LastName
                })
                .ToListAsync();
        }

        /// <summary>
        /// Имплементация на метода връщащ колекция с трансферния модел на всички акаунти
        /// с изключение на текущо логнат администратор
        /// </summary>
        /// <param name="currentUserName">Потребителско име на текущо логнатия администратор</param>
        /// <returns></returns>
        public async Task<IEnumerable<UserTransferModel>> GetAllUsersWhithRole(string currentUserName)
        {
            var operatorsUsers = await this.userManager.GetUsersInRoleAsync(Operator);
            var electriciansUsers = await this.userManager.GetUsersInRoleAsync(Electrician);

            List<UserTransferModel> result = new List<UserTransferModel>();

            foreach (var user in operatorsUsers)
            {
                result.Add(new UserTransferModel()
                {
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName
                });
            }

            foreach (var user in electriciansUsers)
            {
                result.Add(new UserTransferModel()
                {
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName
                });
            }

            return result;
        }


        /// <summary>
        /// Имплементация на метод показващ дали потребителя с идентификатор userId
        /// има права за оборудването в инсталация с идентификатор plantId 
        /// </summary>
        /// <param name="userId">Идентификатор на потребител</param>
        /// <param name="plantId">Идетнификатор на инсталация</param>
        /// <returns></returns>
        public async Task<bool> HasUserPremisionForPlant(Guid userId, Guid plantId) => await this.repo
            .AllReadonly<ApplicationUserPlantInstalation>()
            .Where(ai => ai.UserId.Equals(userId)
                && ai.InstalationId.Equals(plantId)
                && ai.IsActive)
            .AnyAsync();

        /// <summary>
        /// Имплементация на метод показващ дали потребителя има права да се логне в системата
        /// </summary>
        /// <param name="user">Потребител</param>
        /// <returns></returns>
        public async Task<StatusModel> LoginPermissionAsync(UserTransferModel user)
        {

            StatusModel result = new StatusModel()
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

        /// <summary>
        /// Имплементация на метод регистриращ нов потребител
        /// </summary>
        /// <param name="model">Трансферен модел с данните на потребителя</param>
        /// <returns></returns>
        public async Task<StatusModel> RegisterUserAsync(RegisterUserTransferModel model)
        {
            StatusModel result = new StatusModel()
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

            if (!createStatus.Succeeded)
            {
                result.Description = createStatus.Errors.First().Code;
                return result;
            }

            user = await this.userManager.FindByNameAsync(model.UserName);

            var roleAddResult = await this.userManager.AddToRoleAsync(user, model.Role);

            if (!roleAddResult.Succeeded)
            {
                await this.userManager.DeleteAsync(user);
                result.Description = User_Registration_Fail;

                return result;
            }

            var applicationUsersPlantInstalations = new List<ApplicationUserPlantInstalation>();

            foreach (var instalationId in model.Instalations)
            {
                var inst = await this.repo.All<PlantInstalation>(pi => pi.Id == instalationId).FirstOrDefaultAsync();

                if (!(inst is null))
                {
                    var applicationUserPlantInstalation = new ApplicationUserPlantInstalation()
                    {
                        ApplicationUser = user,
                        Instalation = inst,
                        IsActive = true
                    };

                    applicationUsersPlantInstalations.Add(applicationUserPlantInstalation);
                }
            }

            await this.repo.AddRangeAsync(applicationUsersPlantInstalations);
            await this.repo.SaveChangesAsync();

            result.Success = true;

            return result;
        }
    }
}


