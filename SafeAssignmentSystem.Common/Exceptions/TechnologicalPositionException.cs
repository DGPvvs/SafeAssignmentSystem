namespace SafeAssignmentSystem.Common.Exceptions
{
    using System;

    /// <summary>
    /// Изключение за технологична позиция.
    /// </summary>
    public class TechnologicalPositionException : Exception
    {
        private const string Error_Message = "Технологичната позиция не съществува!";

        /// <summary>
        /// Конструктор на изключението TechnologicalPositionException получаващ като параметър съобщение 
        /// </summary>
        /// <param name="message"></param>
        public TechnologicalPositionException(string message) : base(message)
        {

        }

        /// <summary>
        /// Празен конструктор на изключението TechnologicalPositionException задаващ щатното съобщение на класа
        /// при инстанциране на изключението
        /// </summary>
        public TechnologicalPositionException() : this(Error_Message)
        {

        }
    }
}
