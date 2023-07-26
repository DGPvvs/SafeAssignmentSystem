﻿namespace SafeAssignmentSystem.Controllers.AbstractControlers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using static SafeAssignmentSystem.Common.Notification.RoleConstants;

    [Authorize(Roles = $"{Administrator}, {Operator}, {Electrician}")]
    public abstract class BaseReferenceController : AntiforgeryController
    {

    }
}
