namespace SafeAssignmentSystem.Controllers.AbstractControlers
{
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Mvc.Filters;

	[Authorize]
	public class BaseController : Controller
	{
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
