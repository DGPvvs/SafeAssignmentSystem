namespace SafeAssignmentSystem.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SafeAssignmentSystem.Common.Exeptions;
    using SafeAssignmentSystem.Controllers.AbstractControlers;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels;
    using SafeAssignmentSystem.Models.WorkingRotationViewModels;
    using System.Globalization;

    using static SafeAssignmentSystem.Common.Notification.NotificationConstants;

    public class WorkingRotationController : BaseWorkingRotationController
    {
        private readonly IWorkingRotationService workingRotationService;

        public WorkingRotationController(IWorkingRotationService workingRotationService)
        {
            this.workingRotationService = workingRotationService;
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
    }
}
