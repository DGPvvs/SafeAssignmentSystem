namespace SafeAssignmentSystem.Controllers.AbstractControlers
{
    using Microsoft.AspNetCore.Authorization;
    using static SafeAssignmentSystem.Common.Notification.RoleConstants;

    /// <summary>
    /// Базов контролер за работа с нарядите
    /// </summary>
    [Authorize(Roles = $"{Operator}, {Electrician}")]
    public class BaseSafeAssignmentController : AntiforgeryController
    {
    }
}
