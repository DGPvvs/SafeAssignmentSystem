namespace SafeAssignmentSystem.Common.ModelsConstants
{
    public static class ViewModelConstants
    {
        public static class ChangePasswordModelConstants
        {
            public const int New_Password_Max_Length = 10;
            public const int New_Password_Min_Length = 4;
            public const string New_Password_Error_Message = "Новата парола трябва да е дълга между {2} и {1} символа.";

            public const string Confirm_Password_Error_Message = "Потвърдената парола не съвпада с новата парола.";
        }

        public static class ApplicationUserConstants
        {
            public const int FirstName_Max_Length = 20;
            public const int FirstName_Min_Length = 5;
            
            public const int LastName_Max_Length = 20;
            public const int LastName_Min_Length = 5;
        }
    }
}
