﻿namespace SafeAssignmentSystem.Controllers.AbstractControlers
{
    using Microsoft.AspNetCore.Authorization;

    using static SafeAssignmentSystem.Common.Notification.RoleConstants;

    [Authorize(Roles = $"{Administrator}, {Operator}, {Electrician}")]
    public abstract class BaseChoicesPlantsController : AntiforgeryController
    {
    }
}
