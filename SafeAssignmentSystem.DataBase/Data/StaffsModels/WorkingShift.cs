namespace SafeAssignmentSystem.DataBase.Data.StaffsModels
{
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Internal;
	using System;
	using System.ComponentModel.DataAnnotations;

	using static SafeAssignmentSystem.Common.ModelsConstants.DataModelsConstants.WorkingShiftConstants;

	/// <summary>
	/// Модел на смените
	/// </summary>
	[Comment("Модел на смените")]
	public class WorkingShift
    {
		public WorkingShift()
		{
			this.Id = Guid.NewGuid();
		}

		/// <summary>
		/// Идентификационен ключ
		/// </summary>
		[Comment("Идентификационен ключ")]
		[Key]
		public Guid Id { get; set; }

		/// <summary>
		/// Име на смяната
		/// </summary>
		[Comment("Име на смяната")]
		[Required]
		[StringLength(ShiftName_Max_Length)]
		public string ShiftName { get; set; } = null!;

		/// <summary>
		/// Начален час на смяната
		/// </summary>
		[Comment("Начален час на смяната")]
		[Required]
		public DateTime StartTime { get; set; }

		/// <summary>
		/// Краен час на смяната
		/// </summary>
		[Comment("Краен час на смяната")]
		[Required]
		public DateTime EndTime { get; set; }
	}
}
