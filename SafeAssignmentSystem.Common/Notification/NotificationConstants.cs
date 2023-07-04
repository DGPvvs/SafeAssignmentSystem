namespace SafeAssignmentSystem.Common.Notification
{
    public static class NotificationConstants
    {
        public const string Error_Message = "Error_Message";
        public const string Warning_Message = "Warning_Message";
        public const string Information_Message = "Info_Message";
        public const string Success_Message = "Success_Message";

        public const string User_Not_Found = "Потребителят не е намерен!";
        public const string User_Not_Permision_For_Work = "Потребителят не е на смяна!";
        public const string User_Success = "Потребителят има разрешение!";
        public const string User_Change_Password_Success = "Успешно променихте паролата си!";
        public const string User_Change_Password_Not_Allow = "Не успяхте да променихте паролата си!";

        public const string New_Complex_Add_Fail = "Новият комплекс не беше добавен!";
        public const string New_Complex_Add_Success = "Новият комплекс е добавен успешно!";
        public const string Complex_Find_Fail = "Комплекса не беше намерен!";
		public const string Complex_Edit_Exist_In_Deleted = "Комплекс с такива имена вече има сред изтритите комплекси!";
		public const string Complex_Delete_Fail = "Комплека не беше изтрит!";
        public const string Complex_Undelete_Fail = "Комплека не беше възстановен!";
        public const string Complex_Has_Plant = "Комплека не може да бъде изтрит защото има свързани с него инсталации!";

        public const string New_Plant_Add_Fail = "Новата инсталация не беше добавена!";
        public const string New_Plant_Add_Success = "Новата инсталация е добавена успешно!";
        public const string Plant_Find_Fail = "Инсталацията не беше намерена!";

    }
}
