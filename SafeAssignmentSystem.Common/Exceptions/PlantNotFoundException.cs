namespace SafeAssignmentSystem.Common.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Изключение за неоткрита инсталация
    /// </summary>
    public class PlantNotFoundException : Exception
    {
        private const string Message = "Инсталацията не е намерена";

        /// <summary>
        /// Конструктор задаващ външно съобщение за грешка
        /// </summary>
        /// <param name="message"></param>
        public PlantNotFoundException(string message) : base(message)
        {

        }

        /// <summary>
        /// Конструктор задаващ вътрешното съобщение за грешка
        /// </summary>
        public PlantNotFoundException() : this(Message)
        {

        }

    }
}
