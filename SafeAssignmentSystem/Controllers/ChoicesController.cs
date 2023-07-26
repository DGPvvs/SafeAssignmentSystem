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
    using System.Globalization;

    using static SafeAssignmentSystem.Common.Notification.ConditionConstants;
    using static SafeAssignmentSystem.Common.Notification.RoleConstants;
    using static SafeAssignmentSystem.Common.Notification.NotificationConstants;
    using Microsoft.AspNetCore.Identity;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
    using System.Linq;

    /// <summary>
    /// Контролер за избор
    /// </summary>
    public class ChoicesController : BaseChoicesPlantsController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IPlantsService plantsService;
        private readonly IChoisPlantsService choisPlantsService;
        private readonly IAccountService accountService;

        public ChoicesController(
            UserManager<ApplicationUser> userManager,
            IPlantsService plantsService,
            IChoisPlantsService choisPlantsService,
            IAccountService accountService)
        {
            this.userManager = userManager;
            this.plantsService = plantsService;
            this.choisPlantsService = choisPlantsService;
            this.accountService = accountService;
        }

        /// <summary>
        /// Get действие зареждащо модел за избор на инсталация
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="action"></param>
        /// <param name="data">Препратка към следващо действие</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> ChoisPlant(string controller, string action, string data)
        {
            var user = await this.userManager.FindByIdAsync(User.Id());
            var role = new List<string>(await this.userManager.GetRolesAsync(user)).First();

            bool roleFlag = IsAdminCondition.Is_Not_Admin;

            if (role.Equals(Administrator))
            {
                roleFlag = IsAdminCondition.Is_Admin;
            }

            var plants = await this.plantsService.GetAllPlantsAsync(user.Id, roleFlag);            

            var model = new ChoisPlantViewModel()
            {
                RedirectRouter = data,
                Plants = plants.Select(p => new EditPlantViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    FullName = p.FullName
                })
                .ToList()
            };

            return View(model);
        }

        /// <summary>
        /// Post действие получаващо избраната инсталация и предаващо действието нататък
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> ChoisPlant(ChoisPlantViewModel model)
        {
            var user = await this.userManager.FindByIdAsync(User.Id());

            var role = new List<string>(await this.userManager.GetRolesAsync(user)).First();

            bool roleFlag = IsAdminCondition.Is_Not_Admin;

            if (role.Equals(Administrator))
            {
                roleFlag = IsAdminCondition.Is_Admin;
            }

            var plants = await this.plantsService.GetAllPlantsAsync(user.Id, roleFlag);

            if (!this.ModelState.IsValid)
            {
                model.Plants = plants.Select(p => new EditPlantViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    FullName = p.FullName
                })
                .ToList();

                return View(model);
            }

            var rout = model.RedirectRouter.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            var nextRedirect = string.Join(" ", rout.Skip(2));

            return RedirectToAction(rout[1], rout[0], new { plantId = model.Id, data = nextRedirect });
        }

        /// <summary>
        /// Get action предаващ модела на технологичните позиции
        /// към изгледа за избор на технологична позиция
        /// </summary>
        /// <param name="plantId">Идентификатор на инсталация</param>
        /// <param name="data">Препратка към следващо действие</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> ChoisTechnologicalPosition(Guid plantId, string data)
        {
            var transfer = await this.plantsService.GetAllPositionInPlantByIdAsync(plantId, IsDeletedCondition.NotDeleted);
            ChoisTechnologicalPositionViewModel model = new ChoisTechnologicalPositionViewModel()
            {
                Redirection = data,
                TechnologicalPositions = transfer.Select(tp => new EditTechnologicalPositionViewModel()
                {
                    Id = tp.Id,
                    Name = tp.Name
                })
            }; ;

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ChoisTechnologicalPosition(ChoisTechnologicalPositionViewModel model)
        {


            var rout = model.Redirection.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            return RedirectToAction(rout[1], rout[0], new { positionId = model.Id});
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
                .OrderBy(u => u.UserName)
                .Select(u => new KeyValuePair<string, string>(u.UserName, $"{u.FirstName} {u.LastName} ({u.UserName})"))
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

            var allUsers = await this.accountService.GetAllUsers(userName!);

            var s = data.Split(" ", StringSplitOptions.RemoveEmptyEntries);            

            var model = new ChoisUserAndMonthViewModel()
            {
                RedirectAction = s[1],
                RedirectController = s[0],
                Date = string.Empty,
                AllUsers = allUsers
                .OrderBy(u => u.UserName)
                .Select(u => new KeyValuePair<string, string>(u.UserName, $"{u.FirstName} {u.LastName} ({u.UserName})"))
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
