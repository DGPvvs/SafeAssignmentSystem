namespace SafeAssignmentSystem.Common.Exceptions
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

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
