namespace SafeAssignmentSystem.Controllers.AbstractControlers
{
    using Microsoft.AspNetCore.Authorization;

    using static SafeAssignmentSystem.Common.Notification.RoleConstants;

    /// <summary>
    /// базов контролер за комплески, инстелеции и технологични позиции
    /// </summary>
    [Authorize(Roles = Administrator)]
    public abstract class BasePlantsController : AntiforgeryController
    {
    }
}
