namespace SafeAssignmentSystem.Common.ModelsConstants
{
    /// <summary>
    /// Константи описващи моделите от базата данни
    /// </summary>
    public static class DataModelsConstants
    {
        /// <summary>
        /// Константи описващи модела на производство
        /// </summary>
        public static class ProductionComplexConstants
        {
            /// <summary>
            /// Максимална дължина на пълното наименование на комплекса
            /// </summary>
            public const int FullName_Max_Length = 150;

            /// <summary>
            /// Минимална дължина на пълното наименование на комплекса
            /// </summary>
            public const int FullName_Min_Length = 5;

            /// <summary>
            /// Максимална дължина на съкратеното наименование на комплекса
            /// </summary>
            public const int Name_Max_Length = 15;

            /// <summary>
            /// Минимална дължина на съкратеното наименование на комплекса
            /// </summary>
            public const int Name_Min_Length = 3;

            /// <summary>
            /// Съобщение за грешка при неправилно въвеждане на име
            /// </summary>
            public const string Error_Message_Name = "Името на комплекса трябва да е дълго между {2} и {1} символа.";
        }

        /// <summary>
        /// Константи описващи модела на инсталация
        /// </summary>
        public static class PlantInstalationConstants
        {
            /// <summary>
            /// Максимална дължина на пълното наименование на инсталация
            /// </summary>
            public const int FullName_Max_Length = 150;

            /// <summary>
            /// Минимална дължина на пълното наименование на инсталация
            /// </summary>
            public const int FullName_Min_Length = 5;

            /// <summary>
            /// Максимална дължина на съкратеното наименование на инсталация
            /// </summary>
            public const int Name_Max_Length = 15;

            /// <summary>
            /// Минимална дължина на съкратеното наименование на инсталация
            /// </summary>
            public const int Name_Min_Length = 2;

            /// <summary>
            /// Съобщение за грешка при неправилно въвеждане на име
            /// </summary>
            public const string Error_Message_Name = "Името на инсталацията трябва да е дълго между {2} и {1} символа.";
        }

        /// <summary>
        /// Константи описващи модела на технологичната позиция
        /// </summary>
        public static class TechnologicalPositionConstants
        {
            /// <summary>
            /// Максимална дължина на наименование на технологична позиция
            /// </summary>
            public const int Name_Max_Length = 20;

            /// <summary>
            /// Минимална дължина на наименование на технологична позиция
            /// </summary>
            public const int Name_Min_Length = 2;

            /// <summary>
            /// Съобщение за грешка при неправилно въвеждане на име
            /// </summary>
            public const string Error_Message_Name = "Името на технологичната позиция трябва да е дълго между {2} и {1} символа.";
        }

		/// <summary>
		/// Константи описващи модела на смените
		/// </summary>
		public static class WorkingShiftConstants
		{
			/// <summary>
			/// Максимална дължина на наименование на смяна
			/// </summary>
			public const int ShiftName_Max_Length = 10;

            /// <summary>
			/// Минимална дължина на наименование на смяна
			/// </summary>
			public const int ShiftName_Min_Length = 1;
        }

        /// <summary>
		/// Константи описващи модела на потребителите
		/// </summary>
        public static class ApplicationUserConstants
        {
            /// <summary>
            /// Максимална дължина на собственото име на потребителя
            /// </summary>
            public const int FirstName_Max_Length = 20;

            /// <summary>
            /// Максимална дължина на фамилното име на потребителя
            /// </summary>
            public const int LastName_Max_Length = 20;
        }

        /// <summary>
        /// Константи описващи модела на нарядите
        /// </summary>
        public static class SafeAssignmentDocumentConstants
        {
            /// <summary>
            /// Максимална дължина на номера на наряда
            /// </summary>
            public const int Number_Max_Length = 200;
        }
    }
}
