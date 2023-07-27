namespace SafeAssignmentSystem.Controllers.AbstractControlers
{
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Mvc.Filters;

	/// <summary>
	/// Базов контролер за всички логнати потребители
	/// Наследява AntiforgeryController 
	/// </summary>
	[Authorize]
	public abstract class BaseController : AntiforgeryController
    {
		/// <summary>
		/// Пропърти връщащо името на логнатия потребител
		/// </summary>
		public string UserFirstName
		{
			get
			{
				string firstName = string.Empty;
				if (User?.Identity?.IsAuthenticated ?? false && User.HasClaim(c => c.Type == "first_name"))
				{
					firstName = User.Claims.FirstOrDefault(c => c.Type == "first_name")?.Value ?? string.Empty;
				}

				return firstName;
			}
		}

		/// <summary>
		/// Метод изпращащ името на логнатия потребител към изображението
		/// </summary>
		/// <param name="context"></param>
		public override void OnActionExecuted(ActionExecutedContext context)
		{
			if (User?.Identity?.IsAuthenticated ?? false)
			{
				ViewBag.FirstName = this.UserFirstName;
			}

			base.OnActionExecuted(context);
		}
	}
}
