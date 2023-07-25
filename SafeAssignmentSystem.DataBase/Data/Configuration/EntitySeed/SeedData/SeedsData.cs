namespace SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed.SeedData
{
	using Microsoft.AspNetCore.Identity;
	using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
	using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;
	using SafeAssignmentSystem.DataBase.Data.DatabaseModels.StaffsModels;
	using SafeAssignmentSystem.DataBase.Data.FactoryModels;
	using System.Collections.Generic;

	using static SafeAssignmentSystem.Common.Notification.RoleConstants;

	/// <summary>
	/// Клас съдържащ моделите на таблиците от базата с тестовите данни 
	/// </summary>
    public class SeedsData
	{
		/// <summary>
		/// Колекция с тестови роли
		/// </summary>
		/// <returns></returns>
        public IEnumerable<IdentityUserRole<Guid>> SeedUsersRole() =>
            new List<IdentityUserRole<Guid>>()
            {
                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("8a08f81e-e7db-44e8-b639-653d22648577"),
                    UserId = Guid.Parse("3bd76d51-384b-4233-a83e-40e1e1a355dc")
                },

                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("8a08f81e-e7db-44e8-b639-653d22648577"),
                    UserId = Guid.Parse("789fd6e8-ea96-4af7-b417-75284395ceeb")
                },

                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("8a08f81e-e7db-44e8-b639-653d22648577"),
                    UserId = Guid.Parse("15116ebd-a590-489b-96f3-f4b87352ceb3")
                },

                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("8a08f81e-e7db-44e8-b639-653d22648577"),
                    UserId = Guid.Parse("46704eca-2943-4635-ae5b-0b9a4a9fa274")
                },

                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("8a08f81e-e7db-44e8-b639-653d22648577"),
                    UserId = Guid.Parse("ecd856e4-96da-4296-a482-6f66680f1380")
                },

                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("8a08f81e-e7db-44e8-b639-653d22648577"),
                    UserId = Guid.Parse("6a1a286e-7523-4b64-bec5-a5350b4f8169")
                },

                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("26d978a0-e222-4209-a204-f632f093e657"),
                    UserId = Guid.Parse("822edebf-23a5-4373-b56d-94078d984192")
                },

                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("26d978a0-e222-4209-a204-f632f093e657"),
                    UserId = Guid.Parse("b5459434-2a22-47eb-b993-775edc6f4bf1")
                },

                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("26d978a0-e222-4209-a204-f632f093e657"),
                    UserId = Guid.Parse("878d9e51-f7c1-4460-b502-6d3611acc9de")
                },

                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("26d978a0-e222-4209-a204-f632f093e657"),
                    UserId = Guid.Parse("3e3070f2-48d9-4aa4-a760-5654f7d59b14")
                },

                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("26d978a0-e222-4209-a204-f632f093e657"),
                    UserId = Guid.Parse("dc64720a-db37-48a3-b0d9-da13abec71f7")
                },

                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("26d978a0-e222-4209-a204-f632f093e657"),
                    UserId = Guid.Parse("cb0d669c-0739-46cb-af7e-135b3c1359ab")
                },

                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("26d978a0-e222-4209-a204-f632f093e657"),
                    UserId = Guid.Parse("c6f014d9-2816-4d1d-961f-9d313dbeb2ea")
                },

                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("26d978a0-e222-4209-a204-f632f093e657"),
                    UserId = Guid.Parse("291a943f-27f5-45ec-b38a-c97f4e2cba89")
                },

                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("26d978a0-e222-4209-a204-f632f093e657"),
                    UserId = Guid.Parse("08972cfc-c9f9-40fd-8bd9-5cb1a2137512")
                },

                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("26d978a0-e222-4209-a204-f632f093e657"),
                    UserId = Guid.Parse("68c22160-dd62-44e3-b9fa-a5285aeed74a")
                },

                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("26d978a0-e222-4209-a204-f632f093e657"),
                    UserId = Guid.Parse("d5ebbc22-5405-4a37-94d5-b76cb8dd489a")
                },

                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("26d978a0-e222-4209-a204-f632f093e657"),
                    UserId = Guid.Parse("984b9932-5e9b-4bc9-a923-4099f7d488b2")
                },

                new IdentityUserRole<Guid>()
                {
                    RoleId = Guid.Parse("b6d9e0b1-7844-40dd-bd53-cee6cf8f3b62"),
                    UserId = Guid.Parse("f91c5b35-506c-4987-a89a-fba703b53f03")
                }
            };
        public IEnumerable<ApplicationRole> SeedRole() =>
			new List<ApplicationRole>()
			{
				new ApplicationRole()
				{
					Id = Guid.Parse("b6d9e0b1-7844-40dd-bd53-cee6cf8f3b62"),
					Name = Administrator
				},

                new ApplicationRole()
                {
                    Id = Guid.Parse("26d978a0-e222-4209-a204-f632f093e657"),
                    Name = Operator
                },

                new ApplicationRole()
                {
                    Id = Guid.Parse("8a08f81e-e7db-44e8-b639-653d22648577"),
                    Name = Electrician
                },

				new ApplicationRole()
				{
					Id = Guid.Parse("237cb180-758f-465b-8d7d-bff014cf77b8"),
					Name = NoRole
				}				
			};

		public IEnumerable<ApplicationUser> SeedUsers() =>
			new List<ApplicationUser>()
			{
				new ApplicationUser()
				{
					Id = Guid.Parse("3bd76d51-384b-4233-a83e-40e1e1a355dc"),
					FirstName = "Дан",
					LastName = "Игнатов",
					UserName = "Ignatov.Dan",
					UserWorkNumber = 88327
				},

				new ApplicationUser()
				{
					Id = Guid.Parse("789fd6e8-ea96-4af7-b417-75284395ceeb"),
					FirstName = "Сергей",
					LastName = "Попов",
					UserName = "Popov.Sergey",
					UserWorkNumber = 38011
				},

				new ApplicationUser()
				{
					Id = Guid.Parse("15116ebd-a590-489b-96f3-f4b87352ceb3"),
					FirstName = "Жерар",
					LastName = "Славчев",
					UserName = "Gerar.Slavtchev",
					UserWorkNumber = 45571
				},

				new ApplicationUser()
				{
					Id = Guid.Parse("46704eca-2943-4635-ae5b-0b9a4a9fa274"),
					FirstName = "Руси",
					LastName = "Магичов",
					UserName = "Rusi.Magitchov",
					UserWorkNumber = 44454
				},

				new ApplicationUser()
				{
					Id = Guid.Parse("ecd856e4-96da-4296-a482-6f66680f1380"),
					FirstName = "Биню",
					LastName = "Тошков",
					UserName = "Binuy.Tochkov",
					UserWorkNumber = 61815
				},

				new ApplicationUser()
				{
					Id = Guid.Parse("822edebf-23a5-4373-b56d-94078d984192"),
					FirstName = "Пейо",
					LastName = "Ленков",
					UserName = "Peyo.Lenkov",
					UserWorkNumber = 62230
				},

				new ApplicationUser()
				{
					Id = Guid.Parse("878d9e51-f7c1-4460-b502-6d3611acc9de"),
					FirstName = "Аню",
					LastName = "Панчев",
					UserName = "Anuy.Pantchev",
					UserWorkNumber = 65072
				},

				new ApplicationUser()
				{
					Id = Guid.Parse("3e3070f2-48d9-4aa4-a760-5654f7d59b14"),
					FirstName = "Флоро",
					LastName = "Станов",
					UserName = "Floro.Stanov",
					UserWorkNumber = 71417
				},

				new ApplicationUser()
				{
					Id = Guid.Parse("dc64720a-db37-48a3-b0d9-da13abec71f7"),
					FirstName = "Доко",
					LastName = "Цанимиров",
					UserName = "Doko.Tsanimirov",
					UserWorkNumber = 46929
				},

				new ApplicationUser()
				{
					Id = Guid.Parse("cb0d669c-0739-46cb-af7e-135b3c1359ab"),
					FirstName = "Силвиян",
					LastName = "Янов",
					UserName = "Silviyan.Yankov",
					UserWorkNumber = 52291
				},

				new ApplicationUser()
				{
					Id = Guid.Parse("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"),
					FirstName = "Менко",
					LastName = "Мирков",
					UserName = "Menko.Mirkov",
					UserWorkNumber = 19386
				},

				new ApplicationUser()
				{
					Id = Guid.Parse("291a943f-27f5-45ec-b38a-c97f4e2cba89"),
					FirstName = "Лазо",
					LastName = "Шишманов",
					UserName = "Lazo.Chichmanov",
					UserWorkNumber = 68340
				},

				new ApplicationUser()
				{
					Id = Guid.Parse("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"),
					FirstName = "Столипен",
					LastName = "Тонев",
					UserName = "Stolipen.Tonev",
					UserWorkNumber = 38744
				},

				new ApplicationUser()
				{
					Id = Guid.Parse("68c22160-dd62-44e3-b9fa-a5285aeed74a"),
					FirstName = "Дарен",
					LastName = "Павков",
					UserName = "Daren.Pavkov",
					UserWorkNumber = 98129
				},

				new ApplicationUser()
				{
					Id = Guid.Parse("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"),
					FirstName = "Драгни",
					LastName = "Тодоров",
					UserName = "Dragni.Todorov",
					UserWorkNumber = 80738
				},

				new ApplicationUser()
				{
					Id = Guid.Parse("6a1a286e-7523-4b64-bec5-a5350b4f8169"),
					FirstName = "Данимил",
					LastName = "Тинков",
					UserName = "Danimil.Tinkov",
					UserWorkNumber = 70677
				},

				new ApplicationUser()
				{
					Id = Guid.Parse("b5459434-2a22-47eb-b993-775edc6f4bf1"),
					FirstName = "Дориян",
					LastName = "Славейков",
					UserName = "Doriyan.Slaveykov",
					UserWorkNumber = 39676
				},

				new ApplicationUser()
				{
					Id = Guid.Parse("984b9932-5e9b-4bc9-a923-4099f7d488b2"),
					FirstName = "Друмчо",
					LastName = "Светозаров",
					UserName = "Drumtcho.Svetozarov",
					UserWorkNumber = 35236
				},

				new ApplicationUser()
				{
					Id = Guid.Parse("f91c5b35-506c-4987-a89a-fba703b53f03"),
					FirstName = "Захари",
					LastName = "Тодеев",
					UserName = "Zahari.Todeev",
					UserWorkNumber = 50975
				}
			};

		public IEnumerable<PlantInstalation> SeedPlantInstalation() =>
			new List<PlantInstalation>()
			{
				new PlantInstalation()
				{
					Id = Guid.Parse("4dabf64e-adb1-486a-b208-b07c5fabc440"),
					FullName = "Водородна инсталация",
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
					FullName = "МТБЕ и Хидроочистка-1 и 3",
					Name = "МТБЕ и ХО 1, 3",
					ComplexId = Guid.Parse("79afcb01-d8f3-4fe0-9fa2-fd95b72c615f"),
				},

				new PlantInstalation()
				{
					Id = Guid.Parse("c639c036-bdc1-4e54-9425-c77ab00658a3"),
					FullName = "Централна пречиствателна станция",
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
					FullName = "Сярно-кисело алкилиране и абсорбционно газофракциониране",
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

		public IEnumerable<ProductionComplex> SeedComplex() =>
			new List<ProductionComplex>()
			{
				new ProductionComplex()
				{
					Id = Guid.Parse("d90ccba2-389c-4a1a-ac97-5c54340dadd4"),
					FullName = "Дълбочинна преработка на нефт",
					Name = "ДПН",
					IsDeleted = false
				},

				new ProductionComplex()
				{
					Id = Guid.Parse("125b8f04-7c38-4d1b-b39e-6d750e7bd037"),
					FullName = "Енергиен",
					Name = "Eн",
					IsDeleted = false
				},

				new ProductionComplex()
				{
					Id = Guid.Parse("bd922bb0-94af-4bf0-9a99-2431661a27b6"),
					FullName = "Полипропилен",
					Name = "ППр",
					IsDeleted = false
				},

				new ProductionComplex()
				{
					Id = Guid.Parse("79afcb01-d8f3-4fe0-9fa2-fd95b72c615f"),
					FullName = "Първична преработка на нефт",
					Name = "ППН",
					IsDeleted = false
				},

				new ProductionComplex()
				{
					Id = Guid.Parse("fe306aa1-f678-4e94-9d86-308ed58fd305"),
					FullName = "Транспорт и съхранение на нефтопродукти и Пристанищен Терминал",
					Name = "ТСНП и ПТ",
					IsDeleted = false
				}
			};

		public IEnumerable<TechnologicalPosition> SeedTechnologicalPosition() =>
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

		public IEnumerable<WorkingShift> SeedWorkingShift() =>
			new List<WorkingShift>()
			{
				new WorkingShift()
				{
					Id = Guid.Parse("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d"),
					ShiftName = "Р",
					StartTime = new DateTime(1, 1, 1) + new TimeOnly(7, 30).ToTimeSpan(),
					EndTime = new DateTime(1, 1, 1) + new TimeOnly(16, 0).ToTimeSpan()
				},

				new WorkingShift()
				{
					Id = Guid.Parse("51e3023b-5967-4221-ba1e-977fdff10eda"),
					ShiftName = "1",
					StartTime = new DateTime(1, 1, 1) + new TimeOnly(7, 0).ToTimeSpan(),
					EndTime = new DateTime(1, 1, 1) + new TimeOnly(19, 0).ToTimeSpan()
				},

				new WorkingShift()
				{
					Id = Guid.Parse("ad095ab8-ed2b-4f15-9f2d-088188db4ee2"),
					ShiftName = "2",
					StartTime = new DateTime(1, 1, 1) + new TimeOnly(19, 0).ToTimeSpan(),
					EndTime = new DateTime(1, 1, 2) + new TimeOnly(7, 0).ToTimeSpan()
				}
			};

		public IEnumerable<ApplicationUserPlantInstalation> SeedApplicationUserPlantInstalation() =>
			new List<ApplicationUserPlantInstalation>()
			{
				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("3bd76d51-384b-4233-a83e-40e1e1a355dc"),
					InstalationId = Guid.Parse("13d901bf-8203-4280-ae70-24eef3fed196"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("3bd76d51-384b-4233-a83e-40e1e1a355dc"),
					InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("789fd6e8-ea96-4af7-b417-75284395ceeb"),
					InstalationId = Guid.Parse("13d901bf-8203-4280-ae70-24eef3fed196"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("789fd6e8-ea96-4af7-b417-75284395ceeb"),
					InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("15116ebd-a590-489b-96f3-f4b87352ceb3"),
					InstalationId = Guid.Parse("13d901bf-8203-4280-ae70-24eef3fed196"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("15116ebd-a590-489b-96f3-f4b87352ceb3"),
					InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("46704eca-2943-4635-ae5b-0b9a4a9fa274"),
					InstalationId = Guid.Parse("13d901bf-8203-4280-ae70-24eef3fed196"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("46704eca-2943-4635-ae5b-0b9a4a9fa274"),
					InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("ecd856e4-96da-4296-a482-6f66680f1380"),
					InstalationId = Guid.Parse("13d901bf-8203-4280-ae70-24eef3fed196"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("ecd856e4-96da-4296-a482-6f66680f1380"),
					InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("6a1a286e-7523-4b64-bec5-a5350b4f8169"),
					InstalationId = Guid.Parse("13d901bf-8203-4280-ae70-24eef3fed196"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("6a1a286e-7523-4b64-bec5-a5350b4f8169"),
					InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("822edebf-23a5-4373-b56d-94078d984192"),
					InstalationId = Guid.Parse("13d901bf-8203-4280-ae70-24eef3fed196"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("878d9e51-f7c1-4460-b502-6d3611acc9de"),
					InstalationId = Guid.Parse("13d901bf-8203-4280-ae70-24eef3fed196"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("3e3070f2-48d9-4aa4-a760-5654f7d59b14"),
					InstalationId = Guid.Parse("13d901bf-8203-4280-ae70-24eef3fed196"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("dc64720a-db37-48a3-b0d9-da13abec71f7"),
					InstalationId = Guid.Parse("13d901bf-8203-4280-ae70-24eef3fed196"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("cb0d669c-0739-46cb-af7e-135b3c1359ab"),
					InstalationId = Guid.Parse("13d901bf-8203-4280-ae70-24eef3fed196"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("b5459434-2a22-47eb-b993-775edc6f4bf1"),
					InstalationId = Guid.Parse("13d901bf-8203-4280-ae70-24eef3fed196"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"),
					InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("291a943f-27f5-45ec-b38a-c97f4e2cba89"),
					InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"),
					InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("68c22160-dd62-44e3-b9fa-a5285aeed74a"),
					InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"),
					InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c"),
					IsActive = true
				},

				new ApplicationUserPlantInstalation()
				{
					UserId = Guid.Parse("984b9932-5e9b-4bc9-a923-4099f7d488b2"),
					InstalationId = Guid.Parse("973994a0-3ee2-4aba-b422-bc12be18040c"),
					IsActive = true
				}
			};
	}
}