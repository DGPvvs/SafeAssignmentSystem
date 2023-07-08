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
    using System.Text;
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
    }
}
