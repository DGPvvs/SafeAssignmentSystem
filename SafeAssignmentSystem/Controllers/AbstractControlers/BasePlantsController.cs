namespace SafeAssignmentSystem.Controllers.AbstractControlers
{
    using Microsoft.AspNetCore.Authorization;

    using static SafeAssignmentSystem.Common.Notification.RoleConstants;

    [Authorize(Roles = Administrator)]
    public abstract class BasePlantsController : AntiforgeryController
    {
    }
}
