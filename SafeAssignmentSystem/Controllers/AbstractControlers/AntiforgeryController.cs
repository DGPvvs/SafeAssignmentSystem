namespace SafeAssignmentSystem.Controllers.AbstractControlers
{
    using Microsoft.AspNetCore.Mvc;

    [AutoValidateAntiforgeryToken]
    public abstract class AntiforgeryController : Controller
    {

    }
}
