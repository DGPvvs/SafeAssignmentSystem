namespace SafeAssignmentSystem.Controllers.AbstractControlers
{
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Mvc;

	[Authorize]
	public class BaseController : Controller
	{
	}
}
