namespace SafeAssignmentSystem.Common.ModelsConstants
{
    /// <summary>
    /// Клас деклариращ константи за моделите на изгледите
    /// </summary>
    public static class ViewModelConstants
    {
        /// <summary>
        /// Констранти валидиращи модела на изгледа за смяна на паролите
        /// </summary>
        public static class ChangePasswordModelConstants
        {
            /// <summary>
            /// Максимална дължина на паролата
            /// </summary>
            public const int New_Password_Max_Length = 10;

            /// <summary>
            /// Минимална дължина на паролата
            /// </summary>
            public const int New_Password_Min_Length = 4;

            /// <summary>
            /// Съобщение за грешка при неправилно въведена нова парола
            /// </summary>
            public const string New_Password_Error_Message = "Новата парола трябва да е дълга между {2} и {1} символа.";

            /// <summary>
            /// Съобщение за грешка при неправилно повторение на новата парола
            /// </summary>
            public const string Confirm_Password_Error_Message = "Потвърдената парола не съвпада с новата парола.";
        }

		/// <summary>
		/// Констранти валидиращи модела на изгледа за регистрация и промяна на имената на потребители
		/// </summary>
		public static class ApplicationUserConstants
        {
            /// <summary>
            /// Максимална дължина на първото име на потребител
            /// </summary>
            public const int FirstName_Max_Length = 20;

            /// <summary>
            /// Минимална дължина на първото име на потребител
            /// </summary>
            public const int FirstName_Min_Length = 3;


			/// <summary>
			/// Максимална дължина на фамилията на потребител
			/// </summary>
			public const int LastName_Max_Length = 20;

			/// <summary>
			/// Минимална дължина на фамилията на потребител
			/// </summary>
			public const int LastName_Min_Length = 3;
        }
    }
}
