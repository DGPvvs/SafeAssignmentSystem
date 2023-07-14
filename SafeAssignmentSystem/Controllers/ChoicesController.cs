namespace SafeAssignmentSystem.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SafeAssignmentSystem.Controllers.AbstractControlers;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Models.ChoisViewModels;
    using SafeAssignmentSystem.Models.FactoriesViewModels;
    using System;
    using System.Data;

    using static SafeAssignmentSystem.Common.Notification.ConditionConstants;
    using static SafeAssignmentSystem.Common.Notification.RoleConstants;
    using static SafeAssignmentSystem.Common.Notification.NotificationConstants;
    using System.Globalization;

    public class ChoicesController : BaseChoicesPlantsController
    {
        private readonly IPlantsService plantsService;
        private readonly IChoisPlantsService choisPlantsService;
        private readonly IAccountService accountService;

        public ChoicesController(
            IPlantsService plantsService,
            IChoisPlantsService choisPlantsService,
            IAccountService accountService)
        {
            this.plantsService = plantsService;
            this.choisPlantsService = choisPlantsService;
            this.accountService = accountService;
        }

        [HttpGet]
        public async Task<IActionResult> ChoisPlant(string controller, string action, string data)
        {
            var plants = await this.plantsService.GetAllPlantsAsync(IsDeletedCondition.NotDeleted);
            var s = data.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var model = new ChoisPlantViewModel()
            {
                RedirectAction = s[1],
                RedirectController = s[0],
                Plants = plants.Select(p => new EditPlantViewModel()
                {
                    Id = p.Id,
                    Name = p.Name                   
                })
                .ToList()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ChoisPlant(ChoisPlantViewModel model)
        {
            var plants = await this.plantsService.GetAllPlantsAsync(IsDeletedCondition.NotDeleted);

            if (!this.ModelState.IsValid)
            {
                model.Plants = plants.Select(p => new EditPlantViewModel()
                {
                    Id = p.Id,
                    Name = p.Name
                })
                .ToList();

                return View(model);
            }

            return RedirectToAction(model.RedirectAction, model.RedirectController, new { @id = model.Id });
        }

        [HttpGet]
        [Authorize(Roles = Administrator)]
        public async Task<IActionResult> ChoisAccount(string controller, string action, string data)
        {
            var userName = User?.Identity?.Name;

            var allUsers = await this.accountService.GetAllUsers(userName!);
            
            var s = data.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var model = new ChoisAccountViewModel()
            {
                RedirectAction = s[1],
                RedirectController = s[0],
                AllUsers = allUsers
                .Select(u => u.UserName)
                .ToList()
            };

            return this.View(model);
        }

        [HttpPost]
        [Authorize(Roles = Administrator)]
        public async Task<IActionResult> ChoisAccount(ChoisAccountViewModel model)
        {
            var currentUserName = User?.Identity?.Name;

            if (currentUserName == model.User)
            {
                this.TempData[Error_Message] = User_Cant_Edit_Youself;
                ModelState.AddModelError(string.Empty, User_Cant_Edit_Youself);
                return this.RedirectToAction("Index", "Home");
            }

            return this.RedirectToAction(model.RedirectAction, model.RedirectController, new { userName = model.User});
        }

        [HttpGet]
        [Authorize(Roles = Administrator)]
        public async Task<IActionResult> ChoisUserAndMonth(string controller, string action, string data)
        {
            var userName = User?.Identity?.Name;

            var allUsers = await this.accountService.GetAllUsersWhithRole(userName!);

            var s = data.Split(" ", StringSplitOptions.RemoveEmptyEntries);            

            var model = new ChoisUserAndMonthViewModel()
            {
                RedirectAction = s[1],
                RedirectController = s[0],
                Date = string.Empty,
                AllUsers = allUsers
                .Select(u => u.UserName)
                .ToList()
            };

            return this.View(model);
        }

        [HttpPost]
        [Authorize(Roles = Administrator)]
        public async Task<IActionResult> ChoisUserAndMonth(ChoisUserAndMonthViewModel model)
        {
            var currentUserName = User?.Identity?.Name;
            

            if (currentUserName == model.User)
            {
                this.TempData[Error_Message] = User_Cant_Edit_Youself;
                ModelState.AddModelError(string.Empty, User_Cant_Edit_Youself);
                return this.RedirectToAction("Index", "Home");
            }



            bool successDateConvert = DateOnly.TryParseExact(model.Date, Date_Format, CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.None, out DateOnly date);

            if (!successDateConvert)
            {
                this.TempData[Error_Message] = Date_Format_Incorect;

                ModelState.AddModelError(string.Empty, Date_Format_Incorect);
                return this.RedirectToAction("Index", "Home");
            }

            return this.RedirectToAction(model.RedirectAction, model.RedirectController, new { userName = model.User, model.Date });
        }
    }
}
