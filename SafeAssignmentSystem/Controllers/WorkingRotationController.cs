﻿namespace SafeAssignmentSystem.Controllers
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using SafeAssignmentSystem.Common.Exeptions;
    using SafeAssignmentSystem.Common.Overrides;
    using SafeAssignmentSystem.Controllers.AbstractControlers;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
    using SafeAssignmentSystem.Models.CommonViewModels;
    using SafeAssignmentSystem.Models.WorkingRotationViewModels;
    using System;
    using System.Globalization;

    using static SafeAssignmentSystem.Common.Notification.NotificationConstants;

    public class WorkingRotationController : BaseWorkingRotationController
    {
        private readonly IWorkingRotationService workingRotationService;
        private readonly UserManager<ApplicationUser> userManager;

        public WorkingRotationController(
            IWorkingRotationService workingRotationService,
            UserManager<ApplicationUser> userManager)
        {
            this.workingRotationService = workingRotationService;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult ShiftCreate()
        {
            var model = new WorkingShiftViewModel();

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ShiftCreate(WorkingShiftViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            bool successTimeConvert = TimeOnly.TryParseExact(model.StartTime, "HH:mm", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.None, out TimeOnly startTime);

            if (!successTimeConvert)
            {
                this.TempData[Error_Message] = Time_Format_Incorect;
                ModelState.AddModelError(string.Empty, Time_Format_Incorect);
                return View(model);
            }

            successTimeConvert = TimeOnly.TryParseExact(model.EndTime, "HH:mm", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.None, out TimeOnly endTime);

            if (!successTimeConvert)
            {
                this.TempData[Error_Message] = Time_Format_Incorect;
                ModelState.AddModelError(string.Empty, Time_Format_Incorect);
                return View(model);
            }

            ShiftTransferModel transfer = new ShiftTransferModel()
            {
                ShiftName = model.ShiftName.ToUpper(),
                Start = startTime,
                End = endTime
            };

            try
            {
                await this.workingRotationService.AddShiftAsync(transfer);

                this.TempData[Success_Message] = Shift_Add_Success;
                return RedirectToAction("Index", "Home");
            }
            catch (IdentityЕxception ie)
            {
                this.TempData[Error_Message] = ie.Message;
                ModelState.AddModelError(string.Empty, ie.Message);
                return View(model);
            }
            catch (Exception)
            {
                this.TempData[Error_Message] = Shift_Add_Fail;
                ModelState.AddModelError(string.Empty, Shift_Add_Fail);
                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> AllShift()
        {
            var model = await this.workingRotationService.GetAllShiftAsync();

            var viewModel = model.
                Select(ws => new EditWorkingShiftViewModel()
                {
                    Id = ws.Id,
                    ShiftName = ws.ShiftName,
                    EndTime = ws.End.ToString("HH:mm"),
                    StartTime = ws.Start.ToString("HH:mm")
                })
                .OrderBy(ws => ws.ShiftName)
                .ToList();

            return this.View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> EditlShift(Guid id)
        {
            var transfer = await this.workingRotationService.GetShiftByIdAsync(id);

            if (transfer is null)
            {
                this.TempData[Error_Message] = Shift_Find_Fail;
                ModelState.AddModelError(string.Empty, Shift_Find_Fail);
                return this.RedirectToAction("AllShift", "WorkingRotation");
            }

            var model = new EditWorkingShiftViewModel()
            {
                Id = transfer.Id,
                ShiftName = transfer.ShiftName,
                EndTime = transfer.End.ToString("HH:mm"),
                StartTime = transfer.Start.ToString("HH:mm")
            };

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditShift(EditWorkingShiftViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            bool successTimeConvert = TimeOnly.TryParseExact(model.StartTime, "HH:mm", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.None, out TimeOnly startTime);

            if (!successTimeConvert)
            {
                this.TempData[Error_Message] = Time_Format_Incorect;
                ModelState.AddModelError(string.Empty, Time_Format_Incorect);
                return View(model);
            }

            successTimeConvert = TimeOnly.TryParseExact(model.EndTime, "HH:mm", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.None, out TimeOnly endTime);

            if (!successTimeConvert)
            {
                this.TempData[Error_Message] = Time_Format_Incorect;
                ModelState.AddModelError(string.Empty, Time_Format_Incorect);
                return View(model);
            }

            ShiftTransferModel transfer = new ShiftTransferModel()
            {
                Id = model.Id,
                ShiftName = model.ShiftName.ToUpper(),
                Start = startTime,
                End = endTime
            };

            try
            {
                await this.workingRotationService.EditShiftAsync(transfer);

                this.TempData[Success_Message] = Shift_Edit_Success;
                return RedirectToAction("Index", "Home");
            }
            catch (NullReferenceException)
            {
                this.TempData[Error_Message] = Shift_Find_Fail;
                ModelState.AddModelError(string.Empty, Shift_Find_Fail);
                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditChangedSchedule(string userName, string date)
        {
            var user = await this.userManager.FindByNameAsync(userName);

            if (user is null)
            {
                this.TempData[Error_Message] = User_Not_Found;
                return this.RedirectToAction("Index", "Home");
            }

            DateOnly.TryParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.None, out DateOnly datModel);

            AppDateOnly dat = new AppDateOnly(datModel);

            var userShiftsPerPeriod = await this.workingRotationService.GetUserShiftsPerPeriod(user.Id, dat);

            var shiftsList = await this.workingRotationService.GetAllShiftAsync();

            List<ShiftsViewModel> shifts = shiftsList
                .OrderBy(s => s.ShiftName)
                .Select(s => new ShiftsViewModel()
                {
                    ShiftId = s.Id,
                    ShiftName = s.ShiftName
                })
            .ToList();

            shifts.Insert(0, new ShiftsViewModel()
            {
                ShiftName = string.Empty
            });

            DateOnly day = new DateOnly(dat.DateOnly.Year, dat.DateOnly.Month, 1);
            DateOnly endDate = new DateOnly(dat.DateOnly.Year, dat.DateOnly.Month + 1, 1);

            List<ShiftsViewModel> userShifts = new List<ShiftsViewModel>();

            while (day < endDate)
            {
                var userShift = userShiftsPerPeriod.FirstOrDefault(s => s.Date.Year == day.Year &&
                    s.Date.Month == day.Month &&
                    s.Date.Day == day.Day);

                ShiftsViewModel shift = new ShiftsViewModel()
                {
                    Date = day
                };

                if (!(userShift is null))
                {
                    shift.ShiftName = userShift.ShiftName;
                    shift.ShiftId = userShift.ShiftId;
                }

                userShifts.Add(shift);

                day = day.AddDays(1);
            }

            CreateShiftScheduleViewModel model = new CreateShiftScheduleViewModel()
            {
                UserName = user.UserName,
                UserFullName = $"{user.FirstName} {user.LastName}",
                Month = dat.ToString(),
                Year = dat.DateOnly.Year,
                UserShifts = userShifts,
                ShiftsNames = shifts.Select(x => new KeyValuePairViewModel(x.ShiftId, x.ShiftName))
            };


            return this.View(model);
        }
    }
}
