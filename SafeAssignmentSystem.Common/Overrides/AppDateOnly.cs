namespace SafeAssignmentSystem.Common.Overrides
{
    using System;

    /// <summary>
    /// Клас дефиниращ собствена дата
    /// </summary>
    public class AppDateOnly 
    {
        private DateOnly datModel;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="datModel"></param>
        public AppDateOnly(DateOnly datModel)
        {
            this.datModel = datModel;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateOnly DateOnly
        {
            get => this.datModel;
            set => this.datModel = value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            int mounthNum = this.DateOnly.Month;

            switch (mounthNum)
            {
                case 1:
                    return "Януари";
                case 2:
                    return "Февруари";
                case 3:
                    return "Март";
                case 4:
                    return "Април";
                case 5:
                    return "Май";
                case 6:
                    return "Юни";
                case 7:
                    return "Юли";
                case 8:
                    return "Август";
                case 9:
                    return "Септември";
                case 10:
                    return "Октомври";
                case 11:
                    return "Ноември";
                case 12:
                    return "Декември";
                default:
                    return this.DateOnly.ToString();
            }            
        }
    }
}
