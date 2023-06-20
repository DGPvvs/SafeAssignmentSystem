namespace SafeAssignmentSystem.DataBase.Data.SafeAssignmentDocumentModels
{
    using System;

    public class SafeAssignmentDocument
    {
        public SafeAssignmentDocument()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
