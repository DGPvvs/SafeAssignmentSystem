namespace SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;
    using System;
    using System.Collections.Generic;

    internal class PlantInstalationSeeder : IEntityTypeConfiguration<PlantInstalation>
    {
        public void Configure(EntityTypeBuilder<PlantInstalation> builder)
        {
            builder.HasData(SeedPlantInstalation());
        }

        private IEnumerable<PlantInstalation> SeedPlantInstalation() =>
           new List<PlantInstalation>()
           {
                new PlantInstalation()
                {
                    Id = Guid.Parse("4dabf64e-adb1-486a-b208-b07c5fabc440"),
                    FullName = "Водородна",
                    Name = "ВИ",
                    ComplexId = Guid.Parse("d90ccba2-389c-4a1a-ac97-5c54340dadd4")
                },

                new PlantInstalation()
                {
                    Id = Guid.Parse("8b6563b0-5bc0-4778-bc4c-30fa347d9854"),
                    FullName = "Втечнени газове, авто и жп. наливни естакади",
                    Name = "ВГ и АЖПН",
                    ComplexId = Guid.Parse("fe306aa1-f678-4e94-9d86-308ed58fd305"),
                },

                new PlantInstalation()
                {
                    Id = Guid.Parse("13d901bf-8203-4280-ae70-24eef3fed196"),
                    FullName = "Газова сяра",
                    Name = "ГС",
                    ComplexId = Guid.Parse("d90ccba2-389c-4a1a-ac97-5c54340dadd4"),
                },

                new PlantInstalation()
                {
                    Id = Guid.Parse("439d96e7-35fd-4037-a88e-ac56dd11e9d8"),
                    FullName = "Гранулация на полипропилен",
                    Name = "ГППр",
                    ComplexId = Guid.Parse("bd922bb0-94af-4bf0-9a99-2431661a27b6"),
                },

                new PlantInstalation()
                {
                    Id = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c"),
                    FullName = "Каталитичен крекинг",
                    Name = "ККр",
                    ComplexId = Guid.Parse("d90ccba2-389c-4a1a-ac97-5c54340dadd4"),
                },

                new PlantInstalation()
                {
                    Id = Guid.Parse("c7d3bad4-cd8c-4a73-a98c-3e57fc04b09d"),
                    FullName = "Каталитичен реформинг",
                    Name = "КР",
                    ComplexId = Guid.Parse("79afcb01-d8f3-4fe0-9fa2-fd95b72c615f"),
                },

                new PlantInstalation()
                {
                    Id = Guid.Parse("0d5fc355-ba0d-494e-aa2d-421616e9f651"),
                    FullName = "МТБЕ и хидроочистка-1 и 3",
                    Name = "МТБЕ и ХО 1, 3",
                    ComplexId = Guid.Parse("79afcb01-d8f3-4fe0-9fa2-fd95b72c615f"),
                },

                new PlantInstalation()
                {
                    Id = Guid.Parse("c639c036-bdc1-4e54-9425-c77ab00658a3"),
                    FullName = "Очистни съоръжения",
                    Name = "ЦПС",
                    ComplexId = Guid.Parse("125b8f04-7c38-4d1b-b39e-6d750e7bd037"),
                },

                new PlantInstalation()
                {
                    Id = Guid.Parse("38a9c7f5-45b6-4783-a1ba-365f22cb8cea"),
                    FullName = "Полимеризация на пропилен",
                    Name = "ПП",
                    ComplexId = Guid.Parse("bd922bb0-94af-4bf0-9a99-2431661a27b6"),
                },

                new PlantInstalation()
                {
                    Id = Guid.Parse("5078a11e-d2b0-40ca-ae46-79d81197af11"),
                    FullName = "Регенерация на МДЕА и кисели води",
                    Name = "РМДЕА и РКВ",
                    ComplexId = Guid.Parse("d90ccba2-389c-4a1a-ac97-5c54340dadd4"),
                },

                new PlantInstalation()
                {
                    Id = Guid.Parse("7e9d0982-c5fa-493d-b8b1-30babddbdfcc"),
                    FullName = "Регенерация на хексан",
                    Name = "РХ",
                    ComplexId = Guid.Parse("d90ccba2-389c-4a1a-ac97-5c54340dadd4"),
                },

                new PlantInstalation()
                {
                    Id = Guid.Parse("27e67a5e-9def-417e-b479-a3374ac01357"),
                    FullName = "Сярно-кисело алкилиране и абсорбционно газофракциони",
                    Name = "СКА",
                    ComplexId = Guid.Parse("d90ccba2-389c-4a1a-ac97-5c54340dadd4"),
                },

                new PlantInstalation()
                {
                    Id = Guid.Parse("e9e9f60a-057a-4105-8adb-b0f4f0fbfcc5"),
                    FullName = "ТЕЦ и топлопренос",
                    Name = "ТЕЦ",
                    ComplexId = Guid.Parse("125b8f04-7c38-4d1b-b39e-6d750e7bd037"),
                },

                new PlantInstalation()
                {
                    Id = Guid.Parse("0c3d7329-a0af-45ee-8ba2-4ac6b0320e3e"),
                    FullName = "Хидрокрекинг на гудрон",
                    Name = "ХККр",
                    ComplexId = Guid.Parse("d90ccba2-389c-4a1a-ac97-5c54340dadd4"),
                },

                new PlantInstalation()
                {
                    Id = Guid.Parse("35dbc6f8-e63e-46a5-98ec-305161eca10f"),
                    FullName = "Хидрообезсерване на бензин-1 и Хидроочистка-2",
                    Name = "ХО 2",
                    ComplexId = Guid.Parse("79afcb01-d8f3-4fe0-9fa2-fd95b72c615f"),
                },

                new PlantInstalation()
                {
                    Id = Guid.Parse("50465de6-39bd-4370-9e51-b7f60f56130a"),
                    FullName = "Хидроочистка-5",
                    Name = "ХО 5",
                    ComplexId = Guid.Parse("79afcb01-d8f3-4fe0-9fa2-fd95b72c615f"),
                },

                new PlantInstalation()
                {
                    Id = Guid.Parse("e90898e2-831b-4266-8d4c-014cffefcf56"),
                    FullName = "Химично обезсоляване на води и оборотно водоснабдяване",
                    Name = "ХВО",
                    ComplexId = Guid.Parse("125b8f04-7c38-4d1b-b39e-6d750e7bd037"),
                },

                new PlantInstalation()
                {
                    Id = Guid.Parse("c05340da-e358-47f7-822e-bde8030f456a"),
                    FullName = "Централно газофракциониране и хидрообезсерване",
                    Name = "ЦГФИ",
                    ComplexId = Guid.Parse("79afcb01-d8f3-4fe0-9fa2-fd95b72c615f"),
                },

                new PlantInstalation()
                {
                    Id = Guid.Parse("1b3e962a-ab8f-4fec-87d3-3221edb3bad0"),
                    FullName = "Производство на битуми и резервоарен парк за тъмни горива",
                    Name = "БИ",
                    ComplexId = Guid.Parse("d90ccba2-389c-4a1a-ac97-5c54340dadd4"),
                }
           };
    }
}
