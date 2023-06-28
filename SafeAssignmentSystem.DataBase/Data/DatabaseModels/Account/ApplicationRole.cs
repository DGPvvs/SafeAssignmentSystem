namespace SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account
{
	using Microsoft.AspNetCore.Identity;
	using Microsoft.EntityFrameworkCore;
	using System;

	/// <summary>
	/// Модел на ролите
	/// </summary>
	[Comment("Модел на ролите")]
	public class ApplicationRole : IdentityRole<Guid>
	{
	}
}
