namespace SafeAssignmentSystem.Controllers
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using SafeAssignmentSystem.Common.Exeptions;
    using SafeAssignmentSystem.Common.Overrides;
    using SafeAssignmentSystem.Controllers.AbstractControlers;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Models.StatusModels;
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

            bool successTimeConvert = TimeOnly.TryParseExact(model.StartTime, Time_Format, CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.None, out TimeOnly startTime);

            if (!successTimeConvert)
            {
                this.TempData[Error_Message] = Time_Format_Incorect;
                ModelState.AddModelError(string.Empty, Time_Format_Incorect);
                return View(model);
            }

            successTimeConvert = TimeOnly.TryParseExact(model.EndTime, Time_Format, CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.None, out TimeOnly endTime);

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
                    EndTime = ws.End.ToString(Time_Format),
                    StartTime = ws.Start.ToString(Time_Format)
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

            bool successTimeConvert = TimeOnly.TryParseExact(model.StartTime, Time_Format, CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.None, out TimeOnly startTime);

            if (!successTimeConvert)
            {
                this.TempData[Error_Message] = Time_Format_Incorect;
                ModelState.AddModelError(string.Empty, Time_Format_Incorect);
                return View(model);
            }

            successTimeConvert = TimeOnly.TryParseExact(model.EndTime, Time_Format, CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.None, out TimeOnly endTime);

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

            DateOnly.TryParseExact(date, Date_Format, CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.None, out DateOnly datModel);

            AppDateOnly dat = new AppDateOnly(datModel);

            var userShiftsPerPeriod = await this.workingRotationService.GetUserShiftsPerPeriodAsync(user.Id, dat);

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
                ShiftName = Free_Shift
            });

            CreateShiftScheduleViewModel model = new CreateShiftScheduleViewModel()
            {
                UserName = user.UserName,
                UserFullName = $"{user.FirstName} {user.LastName}",
                Month = dat.ToString(),
                Year = dat.DateOnly.Year,
                UserShifts = userShiftsPerPeriod.Select(x => new ShiftsViewModel()
                {
                    ShiftName = x.ShiftName,
                    ShiftId = x.ShiftId,
                    Date = x.Date.ToString(Date_Display_Format)
                }).ToList(),
                ShiftsNames = shifts.Select(x => new KeyValuePairViewModel(x.ShiftId, x.ShiftName)).ToList()
            };

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditChangedSchedule(ShiftScheduleViewModel model)
        {
            if (!ModelState.IsValid)
            {
				this.TempData[Error_Message] = Shift_Roptatin_Edit_Fail;
				ModelState.AddModelError(string.Empty, Shift_Roptatin_Edit_Fail);

				return this.RedirectToAction("Index", "Home");
			}

            var user = await this.userManager.FindByNameAsync(model.UserName);

            DateOnly period = DateOnly.ParseExact(model.UserShifts[0].Date, Date_Display_Format, CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.None);

			var transfer = model.UserShifts
                .Where(us => us.ShiftId != Guid.Empty)
                .Select(us => new ShiftsTransferModel()
                {
                    Date = DateOnly.ParseExact(us.Date, Date_Display_Format, CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.None),
                    ShiftId = us.ShiftId
                })
                .ToList();

            StatusModel status = await this.workingRotationService.ModifyNewShiftsRotationAsync(user.Id, period, transfer);

            if (!status.Success)
            {
                this.TempData[Error_Message] = status.Description;
                ModelState.AddModelError(string.Empty, status.Description);
            }
            else
            {
                this.TempData[Success_Message] = status.Description;
                ModelState.AddModelError(string.Empty, status.Description);
            }			

			return this.RedirectToAction("Index", "Home");
        }

        [HttpGet] //("LoadFromFile")
        public IActionResult LoadFromFile()
        {            
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> LoadFromFile(IFormFile file)
        {
            if (file is null)
            {
                this.TempData[Error_Message] = File_Missing;
                ModelState.AddModelError(string.Empty, File_Missing);

                return this.View();
            }

            var fileName = file.FileName;
            if (!fileName.EndsWith("xlsx"))
            {
                this.TempData[Error_Message] = File_Wrong_Format;
                ModelState.AddModelError(string.Empty, File_Wrong_Format);

                return this.View();
            }
            
            var user = await this.userManager.GetUserAsync(User);

            StatusModel status = await this.workingRotationService.SetWorkingRotation(file, user.UserName);

            if (!status.Success)
            {
                this.TempData[Error_Message] = Shift_Roptatin_Edit_Fail;
                ModelState.AddModelError(string.Empty, Shift_Roptatin_Edit_Fail);
            }
            else
            {
                this.TempData[Success_Message] = status.Description;
                ModelState.AddModelError(string.Empty, status.Description);
            }            

            return this.RedirectToAction("Index", "Home");
        }
    }
}
