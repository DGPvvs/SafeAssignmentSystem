namespace SafeAssignmentSystem.Controllers.AbstractControlers
{
    using Microsoft.AspNetCore.Authorization;

    [Authorize]
    public class BaseSafeAssignmentController : AntiforgeryController
    {
    }
}
