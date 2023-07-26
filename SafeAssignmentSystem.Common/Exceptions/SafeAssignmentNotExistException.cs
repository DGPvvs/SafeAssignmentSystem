namespace SafeAssignmentSystem.Common.Exceptions
{
	using System;

	/// <summary>
	/// Прекъсване указващо, че наряда не е създаден
	/// </summary>
	public class SafeAssignmentNotExistException : Exception
	{
		private const string Error_Message = "Няма създаден наряд с такъв номер!";

        /// <summary>
        /// Конструктор задаващ Message на излючението
        /// </summary>
        /// <param name="message"></param>
        public SafeAssignmentNotExistException(string message) : base(message)
		{

		}

        /// <summary>
        /// Конструктор задаващ за Message вътрешното съобщение за грешка на изключението
        /// </summary>
        public SafeAssignmentNotExistException() : this(Error_Message)
		{

		}
	}
}
