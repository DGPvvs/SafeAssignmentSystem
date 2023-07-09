﻿namespace SafeAssignmentSystem.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.Controllers.AbstractControlers;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Models.StatusModels;
    using SafeAssignmentSystem.Core.Models.TransferModels;
    using SafeAssignmentSystem.Core.Models.TransferModels.UserTransferModels;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
    using SafeAssignmentSystem.Models.AccountViewModels;
    using SafeAssignmentSystem.Models.ChoisViewModels;
    using SafeAssignmentSystem.Models.CommonViewModels;
    using System.Text;

    using static SafeAssignmentSystem.Common.Notification.ConditionConstants;
    using static SafeAssignmentSystem.Common.Notification.NotificationConstants;
    using static SafeAssignmentSystem.Common.Notification.RoleConstants;

    public class AccountController : BaseController
	{
		private readonly UserManager<ApplicationUser> userManager;
		private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<ApplicationRole> roleManager;
		private readonly IAccountService accountService;
        private readonly IPlantsService plantsService;

        
        public AccountController(
			UserManager<ApplicationUser> userManager,
			SignInManager<ApplicationUser> signInManager,
            RoleManager<ApplicationRole> roleManager,
            IAccountService accountService,
            IPlantsService plantsService)
		{
			this.userManager = userManager;
			this.signInManager = signInManager;
            this.roleManager = roleManager;
			this.accountService = accountService;
            this.plantsService = plantsService;
		}

		[HttpGet]
		[AllowAnonymous]
		public IActionResult Login(string? returnUrl = "/")
		{
			var model = new LoginViewModel()
			{
				ReturnUrl = returnUrl!
			};

            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return this.RedirectToAction("Index", "Home");
            }

            return this.View(model);
		}

		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Login(LoginViewModel model)
		{
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            var userPermis = new UserTransferModel()
            {
                UserName = model.UserName
            };

            StatusUserModel userStatus = await this.accountService.LoginPermissionAsync(userPermis);            

            if (userStatus.Success)
            {
                var user = await this.userManager.FindByNameAsync(model.UserName);

                if (!(user is null))
                {
                    var result = await this.signInManager.PasswordSignInAsync(user, model.Password, false, false);

                    if (result.Succeeded)
                    {
						this.TempData[Success_Message] = userStatus.Description;

						if (!(model.ReturnUrl is null))
                        {
                            return this.Redirect(model.ReturnUrl);
                        }
                    }
                    
                    return this.RedirectToAction("Index", "Home");
                }
            }

            this.TempData[Error_Message] = userStatus.Description;

            ModelState.AddModelError(string.Empty, "Невалидно логване!");

            return this.View(model);
		}

        [HttpGet]
        [Authorize(Roles = Administrator)]
        public async Task<IActionResult> Register(string? returnUrl = "/")
        {
            var roles = await this.roleManager.Roles.ToListAsync();
            var allPlants = await this.plantsService.GetAllPlantsAsync(IsDeletedCondition.NotDeleted);

            var model = new RegisterViewModel()
            {
                Instalations = allPlants.Select(p => new CheckBoxViewModel()
                {
                    Name = p.Name,
                    Id = p.Id,
                    Selected = false
                })
                .ToList(),
                Roles = roles.Select(r => new KeyValuePairViewModel(r.Id, r.Name))                
            };            

            return this.View(model);
        }

        [HttpPost]
        [Authorize(Roles = Administrator)]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            var transfer = new RegisterUserTransferModel()
            {
                UserName = model.UserName,
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserWorkNumber = model.UserWorkNumber,
                Password = model.Password,
                Role = model.Role,
                Instalations = model.Instalations
                    .Where(i => i.Selected)
                    .Select(i => i.Name)
                    .ToList()
            };


            StatusUserModel userStatus = await this.accountService.RegisterUserAsync(transfer);
            

            if (!userStatus.Success)
            {
                this.TempData[Error_Message] = userStatus.Description;
                ModelState.AddModelError(string.Empty, userStatus.Description);                
            }
            else
            {
                this.TempData[Success_Message] = User_Registration_Success;
                ModelState.AddModelError(string.Empty, User_Registration_Success);
            }

            return this.RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await this.signInManager.SignOutAsync();

            return this.RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> ChangePassword()
        {
            var user = await userManager.GetUserAsync(User);

            if (user is null)
            {
                this.TempData[Error_Message] = User_Not_Found;
                return this.RedirectToAction("Index", "Home");
            }

            ChangePasswordViewModel model = new ChangePasswordViewModel();

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                 this.View();
            }

            var user = await userManager.GetUserAsync(User);

            if (user is null)
            {
                this.TempData[Error_Message] = User_Not_Found;
                return this.RedirectToAction("Index", "Home");
            }

            var changePasswordResult = await userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

            if (!changePasswordResult.Succeeded)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var error in changePasswordResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                    sb.AppendLine(error.Description);
                }

                this.TempData[Error_Message] = sb.ToString().TrimEnd();
                return this.RedirectToAction("Index", "Home");
            }

            await signInManager.RefreshSignInAsync(user);

            this.TempData[Success_Message] = User_Change_Password_Success;
            return this.RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Authorize(Roles = Administrator)]
        public async Task<IActionResult> EditAccount()
        {
            return this.View();
        }
    }
}
