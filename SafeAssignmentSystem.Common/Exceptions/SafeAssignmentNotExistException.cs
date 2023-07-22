namespace SafeAssignmentSystem.Common.Exceptions
{
	using System;

	public class SafeAssignmentNotExistException : Exception
	{
		private const string Error_Message = "Няма създаден наряд с такъв номер!";
		public SafeAssignmentNotExistException(string message) : base(message)
		{

		}

		public SafeAssignmentNotExistException() : this(Error_Message)
		{

		}
	}
}
