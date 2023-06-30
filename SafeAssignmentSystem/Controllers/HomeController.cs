namespace SafeAssignmentSystem.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SafeAssignmentSystem.Controllers.AbstractControlers;
    using SafeAssignmentSystem.Models;
    using System.Diagnostics;

    public class HomeController : BaseController
	{
        private readonly ILogger<HomeController> _logger;

        public HomeController(
            ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            if (!(User?.Identity?.IsAuthenticated ?? true))
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}