namespace SafeAssignmentSystem.Common.Enums
{
    using System;

    /// <summary>
    /// Енумератор указващ статуса на наряд
    /// </summary>
    [Flags]
    public enum StatusFlagsEnum
    {
        /// <summary>
        /// Наряда е създаден
        /// </summary>
        Created = 0x00000001,

        /// <summary>
        /// Нарядът е открит
        /// </summary>
        Opening = 0x00000002,

        /// <summary>
        /// Нарядът е закрит
        /// </summary>
        Closing = 0x00000004,

        /// <summary>
        /// Поискано е подаване на напрежение
        /// </summary>
        Required = 0x00000008,

        /// <summary>
        /// Подадено е напрежение. Наряда е архивиран
        /// </summary>
        Archived = 0x00000010
    }
}
