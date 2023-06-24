namespace SafeAssignmentSystem.DataBase.Data.Configuration.EntitySeed
{
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class UserSeerData
    {
        public IEnumerable<ApplicationUser> SeedUsers() =>
            new List<ApplicationUser>()
            {
                new ApplicationUser()
                {
                    Id = "3bd76d51-384b-4233-a83e-40e1e1a355dc",
                    FirstName = "Дан",
                    LastName = "Игнатов",
                    UserName = "Ignatov.Dan",
                    UserWorkNumber = 88327
                },

                new ApplicationUser()
                {
                    Id = "789fd6e8-ea96-4af7-b417-75284395ceeb",
                    FirstName = "Сергей",
                    LastName = "Попов",
                    UserName = "Popov.Sergey",
                    UserWorkNumber = 38011
                },

                new ApplicationUser()
                {
                    Id = "15116ebd-a590-489b-96f3-f4b87352ceb3",
                    FirstName = "Жерар",
                    LastName = "Славчев",
                    UserName = "Gerar.Slavtchev",
                    UserWorkNumber = 45571
                },

                new ApplicationUser()
                {
                    Id = "46704eca-2943-4635-ae5b-0b9a4a9fa274",
                    FirstName = "Руси",
                    LastName = "Магичов",
                    UserName = "Rusi.Magitchov",
                    UserWorkNumber = 44454
                },

                new ApplicationUser()
                {
                    Id = "ecd856e4-96da-4296-a482-6f66680f1380",
                    FirstName = "Биню",
                    LastName = "Тошков",
                    UserName = "Binuy.Tochkov",
                    UserWorkNumber = 61815
                },

                new ApplicationUser()
                {
                    Id = "822edebf-23a5-4373-b56d-94078d984192",
                    FirstName = "Пейо",
                    LastName = "Ленков",
                    UserName = "Peyo.Lenkov",
                    UserWorkNumber = 62230
                },

                new ApplicationUser()
                {
                    Id = "878d9e51-f7c1-4460-b502-6d3611acc9de",
                    FirstName = "Аню",
                    LastName = "Панчев",
                    UserName = "Anuy.Pantchev",
                    UserWorkNumber = 65072
                },

                new ApplicationUser()
                {
                    Id = "3e3070f2-48d9-4aa4-a760-5654f7d59b14",
                    FirstName = "Флоро",
                    LastName = "Станов",
                    UserName = "Floro.Stanov",
                    UserWorkNumber = 71417
                },

                new ApplicationUser()
                {
                    Id = "dc64720a-db37-48a3-b0d9-da13abec71f7",
                    FirstName = "Доко",
                    LastName = "Цанимиров",
                    UserName = "Doko.Tsanimirov",
                    UserWorkNumber = 46929
                },

                new ApplicationUser()
                {
                    Id = "cb0d669c-0739-46cb-af7e-135b3c1359ab",
                    FirstName = "Силвиян",
                    LastName = "Янов",
                    UserName = "Silviyan.Yankov",
                    UserWorkNumber = 52291
                },

                new ApplicationUser()
                {
                    Id = "c6f014d9-2816-4d1d-961f-9d313dbeb2ea",
                    FirstName = "Менко",
                    LastName = "Мирков",
                    UserName = "Menko.Mirkov",
                    UserWorkNumber = 19386
                },

                new ApplicationUser()
                {
                    Id = "291a943f-27f5-45ec-b38a-c97f4e2cba89",
                    FirstName = "Лазо",
                    LastName = "Шишманов",
                    UserName = "Lazo.Chichmanov",
                    UserWorkNumber = 68340
                },

                new ApplicationUser()
                {
                    Id = "08972cfc-c9f9-40fd-8bd9-5cb1a2137512",
                    FirstName = "Столипен",
                    LastName = "Тонев",
                    UserName = "Stolipen.Tonev",
                    UserWorkNumber = 38744
                },

                new ApplicationUser()
                {
                    Id = "68c22160-dd62-44e3-b9fa-a5285aeed74a",
                    FirstName = "Дарен",
                    LastName = "Павков",
                    UserName = "Daren.Pavkov",
                    UserWorkNumber = 98129
                },

                new ApplicationUser()
                {
                    Id = "d5ebbc22-5405-4a37-94d5-b76cb8dd489a",
                    FirstName = "Драгни",
                    LastName = "Тодоров",
                    UserName = "Dragni.Todorov",
                    UserWorkNumber = 80738
                },

                new ApplicationUser()
                {
                    Id = "6a1a286e-7523-4b64-bec5-a5350b4f8169",
                    FirstName = "Данимил",
                    LastName = "Тинков",
                    UserName = "Danimil.Tinkov",
                    UserWorkNumber = 70677
                },

                new ApplicationUser()
                {
                    Id = "b5459434-2a22-47eb-b993-775edc6f4bf1",
                    FirstName = "Дориян",
                    LastName = "Славейков",
                    UserName = "Doriyan.Slaveykov",
                    UserWorkNumber = 39676
                },

                new ApplicationUser()
                {
                    Id = "984b9932-5e9b-4bc9-a923-4099f7d488b2",
                    FirstName = "Друмчо",
                    LastName = "Светозаров",
                    UserName = "Drumtcho.Svetozarov",
                    UserWorkNumber = 35236
                },

                new ApplicationUser()
                {
                    Id = "f91c5b35-506c-4987-a89a-fba703b53f03",
                    FirstName = "Захари",
                    LastName = "Тодеев",
                    UserName = "Zahari.Todeev",
                    UserWorkNumber = 50975
                }
            };
    }
}
