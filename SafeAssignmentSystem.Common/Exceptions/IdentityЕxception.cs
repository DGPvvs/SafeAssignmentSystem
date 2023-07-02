namespace SafeAssignmentSystem.Common.Exeptions
{
    using System;

    public class IdentityЕxception : Exception
    {
        private const string Error_Message = "Елементът вече съществува!";
        public IdentityЕxception(string message) : base(message)
        {

        }

        public IdentityЕxception() : this(Error_Message)
        {

        }
    }
}
