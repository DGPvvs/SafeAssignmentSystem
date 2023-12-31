﻿namespace SafeAssignmentSystem.Common.Notification
{
	/// <summary>
	/// Клас инициализиращ нотификационни константи
	/// </summary>
    public static class NotificationConstants
    {
		/// <summary>
		/// Error_Message
		/// </summary>
		public const string Error_Message = "Error_Message";

		/// <summary>
		/// Warning_Message
		/// </summary>
		public const string Warning_Message = "Warning_Message";

		/// <summary>
		/// Info_Message
		/// </summary>
		public const string Information_Message = "Info_Message";

		/// <summary>
		/// Success_Message
		/// </summary>
		public const string Success_Message = "Success_Message";

		/// <summary>
		/// Неуспешна операция
		/// </summary>
		public const string Operation_Fail = "Неуспешна операция";

		/// <summary>
		/// Почивка
		/// </summary>
		public const string Free_Shift = "Почивка";

        /// <summary>
        /// Формат за време
        /// </summary>
        public const string Time_Format = "HH:mm";

        /// <summary>
        /// Формат за дата
        /// </summary>
		public const string Date_Format = "yyyy-MM-dd";

        /// <summary>
        /// Формат на дтата за изобразяване в изгледите
        /// </summary>
		public const string Date_Display_Format = "dd-MM-yyyy";

		/// <summary>
		/// Потребителят не е намерен!
		/// </summary>
		public const string User_Not_Found = "Потребителят не е намерен!";

		/// <summary>
		/// Потребителят не е на смяна!
		/// </summary>
		public const string User_Not_Permision_For_Work = "Потребителят не е на смяна!";

		/// <summary>
		/// Потребителят се присъедини успешно!
		/// </summary>
		public const string User_Success = "Потребителят се присъедини успешно!";

		/// <summary>
		/// Успешно променихте паролата си!
		/// </summary>
		public const string User_Change_Password_Success = "Успешно променихте паролата си!";

        /// <summary>
        /// Успешно променихте паролата!
        /// </summary>
        public const string Change_Password_Success = "Успешно променихте паролата!";

        /// <summary>
        /// Не успяхте да променихте паролата си!
        /// </summary>
        public const string User_Change_Password_Not_Allow = "Не успяхте да променихте паролата си!";

        /// <summary>
        /// Не успяхте да променихте паролата си!
        /// </summary>
        public const string Change_Password_Not_Allow = "Не успяхте да променихте паролата!";

        /// <summary>
        /// Вече има потребител с такова име!
        /// </summary>
        public const string User_Already_Exists = "Вече има потребител с такова име!";

		/// <summary>
		/// Вече има потребител с такъв табелен номер!
		/// </summary>
		public const string User_WorkNumber_Already_Exists = "Вече има потребител с такъв табелен номер!";

        /// <summary>
        /// Не успяхте да направите регистрация!
        /// </summary>
        public const string User_Registration_Fail = "Не успяхте да направите регистрация!";

        /// <summary>
        /// Успешно направихте регистрация!
        /// </summary>
        public const string User_Registration_Success = "Успешно направихте регистрация!";

        /// <summary>
        /// Потребителят не може да редактира сам себе си!
        /// </summary>
        public const string User_Cant_Edit_Youself = "Потребителят не може да редактира сам себе си!";

        /// <summary>
        /// Успешно редактирахте потребителския профил!
        /// </summary>
        public const string User_Edit_Account_Success = "Успешно редактирахте потребителския профил!";

        /// <summary>
        /// Не успяхте да редактирате потребителският профил!
        /// </summary>
        public const string User_Edit_Account_Fail = "Не успяхте да редактирате потребителският профил!";

        /// <summary>
        /// Потребителят няма допуск до съоръженията в инсталацията!
        /// </summary>
        public const string User_Not_Permision = "Потребителят няма допуск до съоръженията в инсталацията!";

        /// <summary>
        /// Потребителят, който се опитвате да редактирате, не е регистриран
        /// </summary>
        public const string User_Not_Registred = "Потребителят, който се опитвате да редактирате, не е регистриран";


        /// <summary>
        /// Новият комплекс не беше добавен!
        /// </summary>
        public const string New_Complex_Add_Fail = "Новият комплекс не беше добавен!";

        /// <summary>
        /// Новият комплекс е добавен успешно!
        /// </summary>
        public const string New_Complex_Add_Success = "Новият комплекс е добавен успешно!";

        /// <summary>
        /// Комплекса не беше намерен!
        /// </summary>
        public const string Complex_Find_Fail = "Комплекса не беше намерен!";

        /// <summary>
        /// Комплекс с такива имена вече има сред изтритите комплекси!
        /// </summary>
        public const string Complex_Edit_Exist_In_Deleted = "Комплекс с такива имена вече има сред изтритите комплекси!";

        /// <summary>
        /// Комплекса не беше изтрит!
        /// </summary>
        public const string Complex_Delete_Fail = "Комплекса не беше изтрит!";

        /// <summary>
        /// Комплекса не беше възстановен!
        /// </summary>
        public const string Complex_Undelete_Fail = "Комплекса не беше възстановен!";

        /// <summary>
        /// Комплекса не може да бъде изтрит защото има свързани с него инсталации!
        /// </summary>
        public const string Complex_Has_Plant = "Комплекса не може да бъде изтрит защото има свързани с него инсталации!";

        /// <summary>
        /// Новата инсталация не беше добавена!
        /// </summary>
        public const string New_Plant_Add_Fail = "Новата инсталация не беше добавена!";

        /// <summary>
        /// Новата инсталация е добавена успешно!
        /// </summary>
        public const string New_Plant_Add_Success = "Новата инсталация е добавена успешно!";

        /// <summary>
        /// Инсталацията не беше намерена!
        /// </summary>
        public const string Plant_Find_Fail = "Инсталацията не беше намерена!";

        /// <summary>
        /// Новата технологична позиция не беше добавена!
        /// </summary>
        public const string New_TechnologicalPosition_Add_Fail = "Новата технологична позиция не беше добавена!";

        /// <summary>
        /// Новата технологична позиция е добавена успешно!
        /// </summary>
        public const string New_TechnologicalPosition_Add_Success = "Новата технологична позиция е добавена успешно!";

        /// <summary>
        /// Технологичната позиция е редактирана успешно!
        /// </summary>
        public const string Edit_TechnologicalPosition_Add_Success = "Технологичната позиция е редактирана успешно!";

        /// <summary>
        /// Технологичната позиция не беше намерена!
        /// </summary>
        public const string TechnologicalPosition_Find_Fail = "Технологичната позиция не беше намерена!";

        /// <summary>
        /// Неправилен формат на час!
        /// </summary>
        public const string Time_Format_Incorect = "Неправилен формат на час!";

        /// <summary>
        /// Неправилен формат на дата!
        /// </summary>
        public const string Date_Format_Incorect = "Неправилен формат на дата!";

        /// <summary>
        /// Успешно добавихте нова смяна!
        /// </summary>
        public const string Shift_Add_Success = "Успешно добавихте нова смяна!";

        /// <summary>
        /// Не успяхте да добавихте нова смяна!
        /// </summary>
        public const string Shift_Add_Fail = "Не успяхте да добавихте нова смяна!";

        /// <summary>
        /// Не беше намерена такава смяна!
        /// </summary>
        public const string Shift_Find_Fail = "Не беше намерена такава смяна!";

        /// <summary>
        /// Успешно редактирахте смяната!
        /// </summary>
        public const string Shift_Edit_Success = "Успешно редактирахте смяната!";


		/// <summary>
		/// Успешно редактирахте сменният график!
		/// </summary>
		public const string Shift_Roptatin_Edit_Success = "Успешно редактирахте сменният график!";

		/// <summary>
		/// Не успяхте да редактирате сменния график!
		/// </summary>
		public const string Shift_Roptatin_Edit_Fail = "Не успяхте да редактирате сменния график!";


		/// <summary>
		/// Не сте избрали файл!
		/// </summary>
		public const string File_Missing = "Не сте избрали файл!";

		/// <summary>
		/// Избраният файл не е с правилният формат!
		/// </summary>
		public const string File_Wrong_Format = "Избраният файл не е с правилният формат!";

		/// <summary>
		/// Наряда не беше регистриран!
		/// </summary>
		public const string Create_SafeAssignment_Document_Fail = "Наряда не беше регистриран!";

		/// <summary>
		/// Успешно регистрирахте наряда!
		/// </summary>
		public const string Create_SafeAssignment_Document_Success = "Успешно регистрирахте наряда!";

		/// <summary>
		/// Успешно открихте наряда!
		/// </summary>
		public const string Opening_SafeAssignment_Document_Success = "Успешно открихте наряда!";

		/// <summary>
		/// Нарядът, който се опитвате да откриете не е със статус заведен!
		/// </summary>
		public const string SafeAssignment_Is_Not_In_Status_Created = "Нарядът, който се опитвате да откриете не е със статус заведен!";		

		/// <summary>
		/// Наряда не беше открит!
		/// </summary>
		public const string Opening_SafeAssignment_Document_Fail = "Наряда не беше открит!";

		/// <summary>
		/// Успешно закрихте наряда!
		/// </summary>
		public const string Closing_SafeAssignment_Document_Success = "Успешно закрихте наряда!";

		/// <summary>
		/// Наряда не беше закрит!
		/// </summary>
		public const string Closing_SafeAssignment_Document_Fail = "Наряда не беше закрит!";

		/// <summary>
		/// Нарядът, който се опитвате да закриете не е със статус открит!
		/// </summary>
		public const string SafeAssignment_Is_Not_In_Status_Opening = "Нарядът, който се опитвате да закриете не е със статус открит!";

		/// <summary>
		/// Няма заведен наряд с такъв номер!
		/// </summary>
		public const string SafeAssignment_Not_Exist = "Няма заведен наряд с такъв номер!";

        /// <summary>
        /// Не може да се направи заявка за подаване на напрежение! За исканата позиция има действащ наряд!
        /// </summary>
        public const string There_Is_Open_Order_For_Position = "Не може да се направи заявка за подаване на напрежение! За исканата позиция има действащ наряд!";

        /// <summary>
        /// Успешно заявихте подаване на напрежение за позицията!
        /// </summary>
        public const string Request_SafeAssignment_Document_Success = "Успешно заявихте подаване на напрежение за позицията!";

        /// <summary>
        /// Позицията е под напрежение! Всички закрити наряди за позицията са архивирани!
        /// </summary>
        public const string Archived_SafeAssignment_Document_Success = "Позицията е под напрежение! Всички закрити наряди за позицията са архивирани!";

        /// <summary>
        /// Заявката не беше направена!
        /// </summary>
        public const string Request_SafeAssignment_Document_Fail = "Заявката за подаване на напрежение на позицията не беше направена!";

        /// <summary>
        /// Не успяхте да регистрирате подаването на напрежение за позицията!
        /// </summary>
        public const string Archived_SafeAssignment_Document_Fail = "Не успяхте да регистрирате подаването на напрежение за позицията!";

        /// <summary>
        /// Не е постъпило искане за подаване на напрежение за тази позиция!
        /// </summary>
        public const string No_Voltage_Request_For_Position = "Не е постъпило искане за подаване на напрежение за тази позиция!";
    }
}
