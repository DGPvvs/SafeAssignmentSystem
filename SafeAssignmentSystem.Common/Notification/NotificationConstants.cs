namespace SafeAssignmentSystem.Common.Notification
{
    public static class NotificationConstants
    {
        public const string Error_Message = "Error_Message";
        public const string Warning_Message = "Warning_Message";
        public const string Information_Message = "Info_Message";
        public const string Success_Message = "Success_Message";

		public const string Free_Shift = "Почивка";

        public const string Time_Format = "HH:mm";
		public const string Date_Format = "yyyy-MM-dd";
		public const string Date_Display_Format = "dd-MM-yyyy";

		public const string User_Not_Found = "Потребителят не е намерен!";
        public const string User_Not_Permision_For_Work = "Потребителят не е на смяна!";
        public const string User_Success = "Потребителят има разрешение!";
        public const string User_Change_Password_Success = "Успешно променихте паролата си!";
        public const string User_Change_Password_Not_Allow = "Не успяхте да променихте паролата си!";
        public const string User_Already_Exists = "Вече има такова потребителско име!";
        public const string User_WorkNumber_Already_Exists = "Вече има потребител с такъв номер!";
        public const string User_Registration_Fail = "Не успяхте да направите регистрация!";
        public const string User_Registration_Success = "Успешно направихте регистрация!";
        public const string User_Cant_Edit_Youself = "Потребителят не може да редактира сам себе си!";

        public const string New_Complex_Add_Fail = "Новият комплекс не беше добавен!";
        public const string New_Complex_Add_Success = "Новият комплекс е добавен успешно!";
        public const string Complex_Find_Fail = "Комплекса не беше намерен!";
		public const string Complex_Edit_Exist_In_Deleted = "Комплекс с такива имена вече има сред изтритите комплекси!";
		public const string Complex_Delete_Fail = "Комплекса не беше изтрит!";
        public const string Complex_Undelete_Fail = "Комплекса не беше възстановен!";
        public const string Complex_Has_Plant = "Комплекса не може да бъде изтрит защото има свързани с него инсталации!";

        public const string New_Plant_Add_Fail = "Новата инсталация не беше добавена!";
        public const string New_Plant_Add_Success = "Новата инсталация е добавена успешно!";
        public const string Plant_Find_Fail = "Инсталацията не беше намерена!";

        public const string New_TechnologicalPosition_Add_Fail = "Новата технологична позиция не беше добавена!";
        public const string New_TechnologicalPosition_Add_Success = "Новата технологична позиция е добавена успешно!";
        public const string TechnologicalPosition_Find_Fail = "Технологичната позиция не беше намерена!";

        public const string Time_Format_Incorect = "Неправилен формат на час!";
        public const string Date_Format_Incorect = "Неправилен формат на дата!";

        public const string Shift_Add_Success = "Успешно добавихте нова смяна!";
        public const string Shift_Add_Fail = "Не успяхте да добавихте нова смяна!";
        public const string Shift_Find_Fail = "Не беше намерена такава смяна!";
        public const string Shift_Edit_Success = "Успешно редактирахте смяната!";

		public const string Shift_Roptatin_Edit_Success = "Успешно редактирахте сменният график!";
		public const string Shift_Roptatin_Edit_Fail = "Не успяхте да редактирате сменния график!";

        public const string File_Missing = "Не сте избрали файл!";
        public const string File_Wrong_Format = "Избраният файл не е с правилният формат!";

        public const string Create_SafeAssignment_Document_Fail = "Наряда не беше регистриран!";
        public const string Create_SafeAssignment_Document_Success = "Успешно регистрирахте наряда!";
    }
}
