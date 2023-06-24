namespace SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SafeAssignmentSystem.DataBase.Data.FactoryModels;
    using System;
    using System.Collections.Generic;

    internal class TechnologicalPositionSeeder : IEntityTypeConfiguration<TechnologicalPosition>
    {
        public void Configure(EntityTypeBuilder<TechnologicalPosition> builder)
        {
            builder.HasData(SeedTechnologicalPosition());
        }

        private IEnumerable<TechnologicalPosition> SeedTechnologicalPosition() =>
            new List<TechnologicalPosition>()
            {
                new TechnologicalPosition()
                {
                    Id = Guid.Parse("0c5e037a-4ad6-4ada-a3c8-bf8aa34b90ee"),
                    Name = "MJ 401 A",
                    InstalationId = Guid.Parse("13d901bf-8203-4280-ae70-24eef3fed196")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("0da0c03c-eb4a-44dd-bb47-2438d7cd128b"),
                    Name = "MJ 401 B",
                    InstalationId = Guid.Parse("13d901bf-8203-4280-ae70-24eef3fed196")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("3e61213e-5e51-4848-a916-51d45fb55dd9"),
                    Name = "B5",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("e4914783-4d0f-4afa-b34e-9cbbf7953558"),
                    Name = "Н102-2",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("ab117d29-20b6-400a-9747-0f8d1b8d098f"),
                    Name = "Н102-P",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("936edbb9-9444-44cd-89f3-80fb27d70e9a"),
                    Name = "ЦК 201-1",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("15d1308a-2e55-467c-b251-ee4b38262723"),
                    Name = "В 403",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("7fcd955b-a234-4f5e-bb1d-68afd2374038"),
                    Name = "ЦК 201-2",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("f48f6af8-4aa4-423f-b24f-9fbdfc4b0b39"),
                    Name = "Н102-1",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("465a93ad-50e3-4b59-991a-1b9d1c04cf4e"),
                    Name = "В7",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("1a452cb1-b1d1-4b48-9159-badcc40ba590"),
                    Name = "В6",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("2c107550-7b23-4478-af9b-448d50d65a23"),
                    Name = "В102",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("cd394570-be68-4b7f-8ee3-d9dc13caaf60"),
                    Name = "ЦП1",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("6e7763d6-a561-4407-b95a-bcc0ec3ec42b"),
                    Name = "ЦП2",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("6cc1db50-1604-4e5a-94de-cc3087cee06e"),
                    Name = "Н 210-3",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("3a7e4c0e-6b25-4707-874d-953d619e7d93"),
                    Name = "Н 109",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("1b1b7597-8065-4b33-8b7e-eb4fae5d4603"),
                    Name = "ПК101Р",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("0487b9c4-ceca-47d0-9ea5-4ef33d9262c2"),
                    Name = "Н 109-1",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("d926a392-d513-45a2-ada8-fe5a05ece6eb"),
                    Name = "ЦК 301",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("a77de888-4132-4f2c-b0f7-bb7ffac78bf0"),
                    Name = "ЦК 301 Р",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("1272bde9-d132-4a76-8be1-da94f41100e6"),
                    Name = "Н 109-2",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("9ed832f2-c9b9-4bcf-b05f-388fe35c794d"),
                    Name = "ПК101",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("c36b152f-e0e7-47b6-8776-ca90537b3b59"),
                    Name = "Н 109-Р",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("2b1bca55-1492-4688-a530-04f88917888b"),
                    Name = "ЦП 3",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                },

                new TechnologicalPosition()
                {
                    Id = Guid.Parse("ace79e04-4547-4161-8212-dda77d678a42"),
                    Name = "ЦП 4",
                    InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c")
                }
            };
    }
}
