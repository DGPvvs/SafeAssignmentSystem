namespace SafeAssignmentSystem.Core.Service
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.Common.Notification;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Data;
    using SafeAssignmentSystem.Core.Models.StatusModels;
    using SafeAssignmentSystem.Core.Models.TransferModels;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using static SafeAssignmentSystem.Common.Notification.NotificationConstants;
    using static SafeAssignmentSystem.Common.Notification.RoleConstants;

    public class AccountService : IAccountService
    {
        private readonly SafeAssignmentDbContext context;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<ApplicationRole> roleManager;

        public AccountService(
            SafeAssignmentDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
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

                var shifts = await this.context.ChangedsSchedules
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







        

DateTime referenceDateTime = new DateTime(1, 1, 1, 0, 0, 0);




///
//StatusUserModel result = new StatusUserModel();

//            var userPermis = await this.userManager.FindByNameAsync(user.UserName);

//            if (userPermis is null)
//            {
//                result.Success = false;
//                result.Description = User_Not_Found;
//                return result;
//            }

//            string userRoles = new List<string>(await this.userManager.GetRolesAsync(userPermis)).First();

//            if (userRoles == Administrator)
//            {
//                result.Success = true;
//                result.Description = User_Success;
//                return result;
//            }

//            if (userRoles == Operator || userRoles == Electrician)
//            {
//                DateTime currentDateTime = DateTime.Now;
//                DateTime date = currentDateTime.Date;

//                var shift = await this.context.ChangedsSchedules
//                    .Where(cs => cs.ApplicationUserId == userPermis.Id && cs.Date.Date == date)
//                    .Select(cs => new UserShiftTransferModel()
//                    {
//                        Start = cs.Shift.StartTime,
//                        End = cs.Shift.EndTime,
//                        Date = cs.Date
//                    })
//                    .ToListAsync();

//                //if (shift.Count > 0)
//                //{
//                //    var start = DateTime.Parse(shift.First().Date.Add(TimeSpan.Parse(shift.First().Start)));

//                //}
                    


//            }

            

//            //var userShifft = this.userManager
//            throw new NotImplementedException();
        }
}
    

