namespace SafeAssignmentSystem.DataBase.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;
    using System;
    using System.Collections.Generic;

    internal class ProductionComplexConfiguration : IEntityTypeConfiguration<ProductionComplex>
    {
        public void Configure(EntityTypeBuilder<ProductionComplex> builder)
        {
            builder.HasData(this.SeedComplex());
        }

        private IEnumerable<ProductionComplex> SeedComplex() =>
           new List<ProductionComplex>()
           {
                new ProductionComplex()
                {
                    Id = Guid.Parse("d90ccba2-389c-4a1a-ac97-5c54340dadd4"),
                    FullName = "Дълбочинна преработка на нефт",
                    Name = "ДПН"
                },

                new ProductionComplex()
                {
                    Id = Guid.Parse("125b8f04-7c38-4d1b-b39e-6d750e7bd037"),
                    FullName = "Енергиен",
                    Name = "Eн"
                },

                new ProductionComplex()
                {
                    Id = Guid.Parse("bd922bb0-94af-4bf0-9a99-2431661a27b6"),
                    FullName = "Полипропилен",
                    Name = "ППр"
                },

                new ProductionComplex()
                {
                    Id = Guid.Parse("79afcb01-d8f3-4fe0-9fa2-fd95b72c615f"),
                    FullName = "Първична преработка на нефт",
                    Name = "ППН"
                },

                new ProductionComplex()
                {
                    Id = Guid.Parse("fe306aa1-f678-4e94-9d86-308ed58fd305"),
                    FullName = "Транспорт и съхранение на нефтопродукти и Пристанищен Терминал",
                    Name = "ТСНП и ПТ"
                }
           };
    }
}
