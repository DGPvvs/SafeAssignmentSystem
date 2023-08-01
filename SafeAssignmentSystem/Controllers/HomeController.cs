namespace SafeAssignmentSystem.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SafeAssignmentSystem.Controllers.AbstractControlers;
    using SafeAssignmentSystem.Models;
    using System.Diagnostics;

    /// <summary>
    /// Контролер на изгледа на началната стряница
    /// </summary>
    public class HomeController : BaseController
	{
        private readonly ILogger<HomeController> _logger;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="logger"></param>
        public HomeController(
            ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get действие на изгледа за начална страница
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Get действие на изгледа за грешка 401 - неоторизиран достъп
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Error401()
        {
            return View();
        }

        /// <summary>
        /// Get действие на изгледа за грешка 404 - страницата не е намерена
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Error404()
        {
            return View();
        }

        /// <summary>
        /// Изглед на страницата за показване на грешки
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}