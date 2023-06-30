namespace SafeAssignmentSystem.Controllers
{
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Identity;
	using Microsoft.AspNetCore.Mvc;
	using SafeAssignmentSystem.Controllers.AbstractControlers;
	using SafeAssignmentSystem.Core.Contracts;
	using SafeAssignmentSystem.Core.Models.StatusModels;
	using SafeAssignmentSystem.Core.Models.TransferModels;
	using SafeAssignmentSystem.Core.Service;
	using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
	using SafeAssignmentSystem.Models;

    using static SafeAssignmentSystem.Common.Notification.NotificationConstants;

    public class AccountController : BaseController
	{
		private readonly UserManager<ApplicationUser> userManager;
		private readonly SignInManager<ApplicationUser> signInManager;
		private readonly IAccountService accountService;
        
        public AccountController(
			UserManager<ApplicationUser> userManager,
			SignInManager<ApplicationUser> signInManager,
            IAccountService accountService)
		{
			this.userManager = userManager;
			this.signInManager = signInManager;
			this.accountService = accountService;
		}

		[HttpGet]
		[AllowAnonymous]
		public IActionResult Login(string? returnUrl = "/")
		{
			var model = new LoginViewModel()
			{
				ReturnUrl = returnUrl
			};

            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return this.RedirectToAction("Index", "Home");
            }

            return View(model);
		}

		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Login(LoginViewModel model)
		{
            if (!ModelState.IsValid)
            {
                return View(model);
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
                            return Redirect(model.ReturnUrl);
                        }
                    }

                    
                    return RedirectToAction("Index", "Home");
                }
            }

            this.TempData[Error_Message] = userStatus.Description;

            ModelState.AddModelError(string.Empty, "Невалидно логване!");

            return View(model);
		}

        public async Task<IActionResult> Logout()
        {
            await this.signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
