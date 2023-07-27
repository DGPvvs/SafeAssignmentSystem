namespace SafeAssignmentSystem.Controllers.AbstractControlers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using static SafeAssignmentSystem.Common.Notification.RoleConstants;

    /// <summary>
    /// Базов контролер за отчети
    /// </summary>
    [Authorize(Roles = $"{Administrator}, {Operator}, {Electrician}")]
    public abstract class BaseReferenceController : AntiforgeryController
    {

    }
}
