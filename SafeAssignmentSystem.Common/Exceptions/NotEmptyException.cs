namespace SafeAssignmentSystem.Common.Exceptions
{
	using System;

	public class NotEmptyException : Exception
	{
		private const string Error_Message = "Към елемента има референции от други таблици!";
		public NotEmptyException(string message) : base(message)
		{

		}

		public NotEmptyException() : this(Error_Message)
		{

		}
	}
}
