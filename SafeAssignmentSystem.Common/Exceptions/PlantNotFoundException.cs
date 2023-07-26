namespace SafeAssignmentSystem.Common.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PlantNotFoundException : Exception
    {
        private const string Message = "Инсталацията не е намерена";

        public PlantNotFoundException(string message) : base(message)
        {

        }

        public PlantNotFoundException() : this(Message)
        {

        }

    }
}
