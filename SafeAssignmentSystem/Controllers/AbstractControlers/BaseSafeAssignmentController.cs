﻿namespace SafeAssignmentSystem.Controllers.AbstractControlers
{
    using Microsoft.AspNetCore.Authorization;
    using static SafeAssignmentSystem.Common.Notification.RoleConstants;

    [Authorize(Roles = $"{Operator}, {Electrician}")]
    public class BaseSafeAssignmentController : AntiforgeryController
    {
    }
}
