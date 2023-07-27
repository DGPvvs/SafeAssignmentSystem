namespace SafeAssignmentSystem.Common.Enums
{
	/// <summary>
	/// Енумератор указващ начина на филтриране при извеждане на списъка на технологичните позиции
	/// </summary>
	public enum FilterCriteria
	{
		/// <summary>
		/// Всички технологични позиции
		/// </summary>
		All = 0,

		/// <summary>
		/// Технологични прозиции в ремонт
		/// </summary>
		UnderRepair = 1,

		/// <summary>
		/// Технологични позиции без напрежение
		/// </summary>
		NoVoltageApplied = 2
	}
}
