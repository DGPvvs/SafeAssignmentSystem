namespace SafeAssignmentSystem.Controllers.AbstractControlers
{
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Основен контролер на WEB слоя на приложението
    /// Всички останали контролери наследяват този контролер
    /// </summary>
    [AutoValidateAntiforgeryToken]
    public abstract class AntiforgeryController : Controller
    {

    }
}
