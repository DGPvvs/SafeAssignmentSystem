namespace SafeAssignmentSystem.Controllers.AbstractControlers
{
    using Microsoft.AspNetCore.Authorization;

    using static SafeAssignmentSystem.Common.Notification.RoleConstants;

    /// <summary>
    /// Базов контролер за избор
    /// </summary>
    [Authorize(Roles = $"{Administrator}, {Operator}, {Electrician}")]
    public abstract class BaseChoicesPlantsController : AntiforgeryController
    {
    }
}
