namespace SafeAssignmentSystem.Common.Exeptions
{
    using System;

    /// <summary>
    /// Изключение за идентичност.
    /// </summary>
    public class IdentityЕxception : Exception
    {
        private const string Error_Message = "Елементът вече съществува!";

        /// <summary>
        /// Конструктор на изключението IdentityЕxception получаващ като параметър съобщение 
        /// </summary>
        /// <param name="message">Съобщението, което получава изключението</param>
        public IdentityЕxception(string message) : base(message)
        {

        }

        /// <summary>
        /// Празен конструктор на изключението IdentityЕxception задаващ щатното съобщение на класа
        /// при инстанциране на изключението
        /// </summary>
        public IdentityЕxception() : this(Error_Message)
        {

        }
    }
}
