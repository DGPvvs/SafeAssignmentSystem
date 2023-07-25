namespace SafeAssignmentSystem.Common.Exceptions
{
	using System;

	/// <summary>
	/// Прекъсване указващо, че елемента не е празен
	/// </summary>
	public class NotEmptyException : Exception
	{
		private const string Error_Message = "Към елемента има референции от други таблици!";
		public NotEmptyException(string message) : base(message)
		{

		}

		/// <summary>
		/// Конструктор задаващ за Message вътрешното съобщение за грешка на изключението
		/// </summary>
		public NotEmptyException() : this(Error_Message)
		{

		}
	}
}
