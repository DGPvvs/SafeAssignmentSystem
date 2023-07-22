namespace SafeAssignmentSystem.Common.Notification
{
    /// <summary>
    /// Клас дефиниращ условните константи
    /// </summary>
    public static class ConditionConstants
    {
        public static class IsDeletedCondition
        {
            /// <summary>
            /// Елементът е маркиран като изтрит
            /// </summary>
            public const bool Deleted = true;

            /// <summary>
            /// Елементът е маркиран като неизтрит
            /// </summary>
            public const bool NotDeleted = false;
        }

        /// <summary>
        /// Клас дефиниращ константите декфиниращи 
        /// дали потребителя е администратор или не
        /// </summary>
        public static class IsAdminCondition
        {
            /// <summary>
            /// Логнатият потребител е администратор
            /// </summary>
            public const bool Is_Admin = true;

            /// <summary>
            /// Логнатият потребител не е администратор
            /// </summary>
            public const bool Is_Not_Admin = false;
        }


    }
}
