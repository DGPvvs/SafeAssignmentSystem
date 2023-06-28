using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafeAssignmentSystem.DataBase.Migrations
{
    public partial class SeedDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserWorkNumber" },
                values: new object[,]
                {
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), 0, "7c4c95a1-7250-42da-8f1c-0e75fbe9867e", null, false, "Столипен", "Тонев", false, null, null, "STOLIPEN.TONEV", "AQAAAAEAACcQAAAAEPTI0ofIhKIifm+CTpH5QnV1NXTf2bhMBEwA+or1ETd7ufBk7Z1zUWLihA2AFkznXw==", null, false, null, false, "Stolipen.Tonev", 38744 },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), 0, "9a62a788-4f4d-4ae4-a181-01a1bec8eed8", null, false, "Жерар", "Славчев", false, null, null, "GERAR.SLAVTCHEV", "AQAAAAEAACcQAAAAELldqgo3amFQH8XMdp1YT82OFhcv0rbrqoNPa24EoOyaiug418MOf1Fkwgeyt5lygQ==", null, false, null, false, "Gerar.Slavtchev", 45571 },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), 0, "26fbe6b2-4fe6-408c-89fa-9d9a3acdfcb0", null, false, "Лазо", "Шишманов", false, null, null, "LAZO.CHICHMANOV", "AQAAAAEAACcQAAAAEHs+DQgSpoISgkz/8T0d1gz88CkokhIyjT/s/cgMZb4WkbLvVtmPTuGh+6QykDDc4Q==", null, false, null, false, "Lazo.Chichmanov", 68340 },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), 0, "bc34394f-6eb7-41b0-8e03-5fa1637e07c8", null, false, "Дан", "Игнатов", false, null, null, "IGNATOV.DAN", "AQAAAAEAACcQAAAAEFM6MaJpkCZQHEpeQjK2thaNKyBswGeeFDOrQHljv7gIyCYPwh8ULD2WvHeukYJBQw==", null, false, null, false, "Ignatov.Dan", 88327 },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), 0, "4dac51aa-ea80-49fe-ac94-086e978cc3e4", null, false, "Флоро", "Станов", false, null, null, "FLORO.STANOV", "AQAAAAEAACcQAAAAENQ/aIG6phBF2IeDEZb66xITRJXoejn1FRZFgrFLl86GK2yZ0BlJJRUc6JVXVh1KHQ==", null, false, null, false, "Floro.Stanov", 71417 },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), 0, "b977a65a-acd5-486a-8dad-ec00ab996067", null, false, "Руси", "Магичов", false, null, null, "RUSI.MAGITCHOV", "AQAAAAEAACcQAAAAEPI7s62q9nQv2wSTlp8WRoHpDiWCNSPa3yn2bQo0S/07TSM+ucS+F9Uhgi98Gwamvg==", null, false, null, false, "Rusi.Magitchov", 44454 },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), 0, "1d32c972-91f8-4bfb-97cd-ef76244e13cc", null, false, "Дарен", "Павков", false, null, null, "DAREN.PAVKOV", "AQAAAAEAACcQAAAAEMmk/devN8bLUyHCmPEjlJQ8z5xw8028pWt+dEOC9xAvdivSO+AFEY18yAFMqMjk5Q==", null, false, null, false, "Daren.Pavkov", 98129 },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), 0, "fa8bfb6a-86e4-4302-99a9-dfa9962b8aeb", null, false, "Данимил", "Тинков", false, null, null, "DANIMIL.TINKOV", "AQAAAAEAACcQAAAAEIKQZy8tfQlMOk4Jp5L3UR7C74U3zX/wcZygukxb1soapx4RtLbxZrSLCvycW0WYCw==", null, false, null, false, "Danimil.Tinkov", 70677 },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), 0, "4cb4421d-5c0b-439c-a2b9-2f9ac1cd3220", null, false, "Сергей", "Попов", false, null, null, "POPOV.SERGEY", "AQAAAAEAACcQAAAAECT6yaubWf7ZaaurZOd6WpEYgRG/WgIoEOrCHLF6ya2nD9fGEm6m26g3Tdq8EKzFew==", null, false, null, false, "Popov.Sergey", 38011 },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), 0, "8015e57b-c574-4c13-840a-242d48d2f96a", null, false, "Пейо", "Ленков", false, null, null, "PEYO.LENKOV", "AQAAAAEAACcQAAAAEJcbBtUxg1Uo8Mjws2ij5wWJOvlqO+5oYdJ93X8NRBw1Ewdk2xvhQqBDrPBHyfRPqw==", null, false, null, false, "Peyo.Lenkov", 62230 },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), 0, "bd3950ff-aa53-455f-8dfd-f2058d7cbae9", null, false, "Аню", "Панчев", false, null, null, "ANUY.PANTCHEV", "AQAAAAEAACcQAAAAECfvxuf3fwF+74XGiHDKzPHJbodxIMX6zWQ9Fr1AFHmfuoijyJqo3XqGr7AKY855uw==", null, false, null, false, "Anuy.Pantchev", 65072 },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), 0, "1ee8ebb8-610b-4471-a8f7-c1416d7cb7da", null, false, "Друмчо", "Светозаров", false, null, null, "DRUMTCHO.SVETOZAROV", "AQAAAAEAACcQAAAAEBmT/KA/g9hIvo9UNonO6nBolbEfAcq6SE1MrHyeO1EYwIyBbxH5QFOATLFZ9s789A==", null, false, null, false, "Drumtcho.Svetozarov", 35236 },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), 0, "41287839-fa0f-44db-baeb-ea79f0f4ef4b", null, false, "Дориян", "Славейков", false, null, null, "DORIYAN.SLAVEYKOV", "AQAAAAEAACcQAAAAEHWCNUaD99dJwz7SoC++Nhna8YTqxLaMQA52sBSkAHoBxCy/Z2WcuIvGNxPzIM+gtg==", null, false, null, false, "Doriyan.Slaveykov", 39676 },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), 0, "a0e7d042-dc38-4729-be97-a9f9d0e96f6e", null, false, "Менко", "Мирков", false, null, null, "MENKO.MIRKOV", "AQAAAAEAACcQAAAAELskYzIVJ36S85gAtHMThOd9UpxrQLQwqPmpR2JzIrJjnWTgMMWRn/gn5JOjFQbGXA==", null, false, null, false, "Menko.Mirkov", 19386 },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), 0, "211971cf-727e-44d5-978c-0fae5bd1cd63", null, false, "Силвиян", "Янов", false, null, null, "SILVIYAN.YANKOV", "AQAAAAEAACcQAAAAEK+1apExWodfcnyKBallBcAjMnH6C1FiZ97Bg1dVwe5oHH6Nob5lO+TiMMAhY37OpQ==", null, false, null, false, "Silviyan.Yankov", 52291 },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), 0, "d2c9fe43-d49e-4875-ab4a-da840ae31de5", null, false, "Драгни", "Тодоров", false, null, null, "DRAGNI.TODOROV", "AQAAAAEAACcQAAAAEL0/esXr9kVJ0KkmjFOBlf0tjZiJIcBLFbagJ8DMbMY4fvOYVtrvzV11hs/nTlHynw==", null, false, null, false, "Dragni.Todorov", 80738 },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), 0, "315061f8-0bf7-4204-8ff5-4f1bdf43aec4", null, false, "Доко", "Цанимиров", false, null, null, "DOKO.TSANIMIROV", "AQAAAAEAACcQAAAAEL4qt6NTMrRvlUxB4oaRs0f/C3SBxkX5rhDvrMAMsJOlc/fQufP6fHlSFO0ZiW8OaA==", null, false, null, false, "Doko.Tsanimirov", 46929 },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), 0, "471e283b-1b90-4175-956c-1aed3d56e422", null, false, "Биню", "Тошков", false, null, null, "BINUY.TOCHKOV", "AQAAAAEAACcQAAAAEG7GTwcLUvbaYucBmk4VGs9vMV6PK88g3jKBrIfjPNNR7azLsA8w6nphxSqlSp2aWw==", null, false, null, false, "Binuy.Tochkov", 61815 },
                    { new Guid("f91c5b35-506c-4987-a89a-fba703b53f03"), 0, "6c3a02f0-ed6c-469e-8250-5ebe13c269da", null, false, "Захари", "Тодеев", false, null, null, "ZAHARI.TODEEV", "AQAAAAEAACcQAAAAECqhDxrKO/lGAAyfVyg782TRavJbWTuwq4myMmV7IZi+1iFmar9zvgurdqxRIbw7dw==", null, false, null, false, "Zahari.Todeev", 50975 }
                });

            migrationBuilder.InsertData(
                table: "ProductionComplexes",
                columns: new[] { "Id", "FullName", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("125b8f04-7c38-4d1b-b39e-6d750e7bd037"), "Енергиен", false, "Eн" },
                    { new Guid("79afcb01-d8f3-4fe0-9fa2-fd95b72c615f"), "Първична преработка на нефт", false, "ППН" },
                    { new Guid("bd922bb0-94af-4bf0-9a99-2431661a27b6"), "Полипропилен", false, "ППр" },
                    { new Guid("d90ccba2-389c-4a1a-ac97-5c54340dadd4"), "Дълбочинна преработка на нефт", false, "ДПН" },
                    { new Guid("fe306aa1-f678-4e94-9d86-308ed58fd305"), "Транспорт и съхранение на нефтопродукти и Пристанищен Терминал", false, "ТСНП и ПТ" }
                });

            migrationBuilder.InsertData(
                table: "WorkingShifts",
                columns: new[] { "Id", "EndTime", "ShiftName", "StartTime" },
                values: new object[,]
                {
                    { new Guid("51e3023b-5967-4221-ba1e-977fdff10eda"), new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "1", new DateTime(1, 1, 1, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d"), new DateTime(1, 1, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "Р", new DateTime(1, 1, 1, 7, 30, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2"), new DateTime(1, 1, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), "2", new DateTime(1, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 6, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 6, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 6, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 6, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 6, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 6, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 6, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 6, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 6, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 6, 29, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 6, 29, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 6, 29, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 6, 29, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 6, 29, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 6, 29, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 6, 29, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 6, 29, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 6, 29, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 6, 30, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 6, 30, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 6, 30, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 6, 30, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 6, 30, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 6, 30, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 6, 30, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 6, 30, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 6, 30, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 1, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 1, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 1, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 1, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 1, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 1, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 1, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 1, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 1, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 2, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 2, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 2, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 2, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 2, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 2, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 2, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 2, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 2, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 4, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 4, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 4, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 4, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 4, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 4, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 4, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 4, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 4, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 5, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 5, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 5, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 5, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 5, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 5, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 5, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 5, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 5, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 6, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 6, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 6, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 6, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 6, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 6, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 6, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 6, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 6, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 7, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 7, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 7, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 7, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 7, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 7, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 7, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 7, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 7, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 8, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 8, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 8, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 8, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 8, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 8, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 8, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 8, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 8, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 9, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 9, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 9, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 9, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 9, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 9, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 9, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 9, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 9, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 10, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 10, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 10, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 10, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 10, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 10, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 10, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 10, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 10, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 11, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 11, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 11, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 11, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 11, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 11, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 11, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 11, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 11, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 12, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 12, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 12, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 12, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 12, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 12, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 12, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 12, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 12, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 13, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 13, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 13, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 13, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 13, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 13, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 13, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 13, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 13, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 14, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 14, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 14, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 14, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 14, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 14, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 14, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 14, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 14, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 15, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 15, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 15, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 15, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 15, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 15, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 15, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 15, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 15, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 16, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 16, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 16, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 16, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 16, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 16, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 16, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 16, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 16, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 17, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 17, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 17, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 17, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 17, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 17, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 17, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 17, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 17, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 18, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 18, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 18, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 18, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 18, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 18, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 18, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 18, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 18, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 19, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 19, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 19, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 19, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 19, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 19, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 19, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 19, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 19, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 20, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 20, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 20, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 20, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 20, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 20, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 20, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 20, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 20, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 21, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 21, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 21, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 21, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 21, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 21, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 21, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 21, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 21, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 22, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 22, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 22, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 22, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 22, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 22, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 22, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 22, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 22, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 23, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 23, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 23, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 23, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 23, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 23, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 23, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 23, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 23, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 24, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 24, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 24, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 24, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 24, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 24, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 24, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 24, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 24, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 25, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 25, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 25, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 25, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 25, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 25, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 25, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 25, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 25, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 26, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 26, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 26, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 26, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 26, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 26, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 26, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 26, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 26, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 27, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 27, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 27, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 27, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 27, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 27, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 27, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 27, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 27, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "PlantInstalations",
                columns: new[] { "Id", "ComplexId", "FullName", "Name" },
                values: new object[,]
                {
                    { new Guid("0c3d7329-a0af-45ee-8ba2-4ac6b0320e3e"), new Guid("d90ccba2-389c-4a1a-ac97-5c54340dadd4"), "Хидрокрекинг на гудрон", "ХККр" },
                    { new Guid("0d5fc355-ba0d-494e-aa2d-421616e9f651"), new Guid("79afcb01-d8f3-4fe0-9fa2-fd95b72c615f"), "МТБЕ и хидроочистка-1 и 3", "МТБЕ и ХО 1, 3" },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("d90ccba2-389c-4a1a-ac97-5c54340dadd4"), "Газова сяра", "ГС" },
                    { new Guid("1b3e962a-ab8f-4fec-87d3-3221edb3bad0"), new Guid("d90ccba2-389c-4a1a-ac97-5c54340dadd4"), "Производство на битуми и резервоарен парк за тъмни горива", "БИ" },
                    { new Guid("27e67a5e-9def-417e-b479-a3374ac01357"), new Guid("d90ccba2-389c-4a1a-ac97-5c54340dadd4"), "Сярно-кисело алкилиране и абсорбционно газофракциони", "СКА" },
                    { new Guid("35dbc6f8-e63e-46a5-98ec-305161eca10f"), new Guid("79afcb01-d8f3-4fe0-9fa2-fd95b72c615f"), "Хидрообезсерване на бензин-1 и Хидроочистка-2", "ХО 2" },
                    { new Guid("38a9c7f5-45b6-4783-a1ba-365f22cb8cea"), new Guid("bd922bb0-94af-4bf0-9a99-2431661a27b6"), "Полимеризация на пропилен", "ПП" },
                    { new Guid("439d96e7-35fd-4037-a88e-ac56dd11e9d8"), new Guid("bd922bb0-94af-4bf0-9a99-2431661a27b6"), "Гранулация на полипропилен", "ГППр" },
                    { new Guid("4dabf64e-adb1-486a-b208-b07c5fabc440"), new Guid("d90ccba2-389c-4a1a-ac97-5c54340dadd4"), "Водородна", "ВИ" },
                    { new Guid("50465de6-39bd-4370-9e51-b7f60f56130a"), new Guid("79afcb01-d8f3-4fe0-9fa2-fd95b72c615f"), "Хидроочистка-5", "ХО 5" },
                    { new Guid("5078a11e-d2b0-40ca-ae46-79d81197af11"), new Guid("d90ccba2-389c-4a1a-ac97-5c54340dadd4"), "Регенерация на МДЕА и кисели води", "РМДЕА и РКВ" },
                    { new Guid("7e9d0982-c5fa-493d-b8b1-30babddbdfcc"), new Guid("d90ccba2-389c-4a1a-ac97-5c54340dadd4"), "Регенерация на хексан", "РХ" }
                });

            migrationBuilder.InsertData(
                table: "PlantInstalations",
                columns: new[] { "Id", "ComplexId", "FullName", "Name" },
                values: new object[,]
                {
                    { new Guid("8b6563b0-5bc0-4778-bc4c-30fa347d9854"), new Guid("fe306aa1-f678-4e94-9d86-308ed58fd305"), "Втечнени газове, авто и жп. наливни естакади", "ВГ и АЖПН" },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("d90ccba2-389c-4a1a-ac97-5c54340dadd4"), "Каталитичен крекинг", "ККр" },
                    { new Guid("c05340da-e358-47f7-822e-bde8030f456a"), new Guid("79afcb01-d8f3-4fe0-9fa2-fd95b72c615f"), "Централно газофракциониране и хидрообезсерване", "ЦГФИ" },
                    { new Guid("c639c036-bdc1-4e54-9425-c77ab00658a3"), new Guid("125b8f04-7c38-4d1b-b39e-6d750e7bd037"), "Очистни съоръжения", "ЦПС" },
                    { new Guid("c7d3bad4-cd8c-4a73-a98c-3e57fc04b09d"), new Guid("79afcb01-d8f3-4fe0-9fa2-fd95b72c615f"), "Каталитичен реформинг", "КР" },
                    { new Guid("e90898e2-831b-4266-8d4c-014cffefcf56"), new Guid("125b8f04-7c38-4d1b-b39e-6d750e7bd037"), "Химично обезсоляване на води и оборотно водоснабдяване", "ХВО" },
                    { new Guid("e9e9f60a-057a-4105-8adb-b0f4f0fbfcc5"), new Guid("125b8f04-7c38-4d1b-b39e-6d750e7bd037"), "ТЕЦ и топлопренос", "ТЕЦ" }
                });

            migrationBuilder.InsertData(
                table: "ApplicationUserPlantInstalations",
                columns: new[] { "InstalationId", "UserId", "IsActive" },
                values: new object[,]
                {
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("822edebf-23a5-4373-b56d-94078d984192"), true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), true }
                });

            migrationBuilder.InsertData(
                table: "TechnologicalPositions",
                columns: new[] { "Id", "InstalationId", "Name" },
                values: new object[,]
                {
                    { new Guid("0487b9c4-ceca-47d0-9ea5-4ef33d9262c2"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "Н 109-1" },
                    { new Guid("0c5e037a-4ad6-4ada-a3c8-bf8aa34b90ee"), new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "MJ 401 A" },
                    { new Guid("0da0c03c-eb4a-44dd-bb47-2438d7cd128b"), new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "MJ 401 B" },
                    { new Guid("1272bde9-d132-4a76-8be1-da94f41100e6"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "Н 109-2" },
                    { new Guid("15d1308a-2e55-467c-b251-ee4b38262723"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "В 403" },
                    { new Guid("1a452cb1-b1d1-4b48-9159-badcc40ba590"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "В6" },
                    { new Guid("1b1b7597-8065-4b33-8b7e-eb4fae5d4603"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "ПК101Р" },
                    { new Guid("2b1bca55-1492-4688-a530-04f88917888b"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "ЦП 3" },
                    { new Guid("2c107550-7b23-4478-af9b-448d50d65a23"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "В102" },
                    { new Guid("3a7e4c0e-6b25-4707-874d-953d619e7d93"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "Н 109" },
                    { new Guid("3e61213e-5e51-4848-a916-51d45fb55dd9"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "B5" },
                    { new Guid("465a93ad-50e3-4b59-991a-1b9d1c04cf4e"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "В7" },
                    { new Guid("6cc1db50-1604-4e5a-94de-cc3087cee06e"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "Н 210-3" },
                    { new Guid("6e7763d6-a561-4407-b95a-bcc0ec3ec42b"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "ЦП2" },
                    { new Guid("7fcd955b-a234-4f5e-bb1d-68afd2374038"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "ЦК 201-2" },
                    { new Guid("936edbb9-9444-44cd-89f3-80fb27d70e9a"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "ЦК 201-1" },
                    { new Guid("9ed832f2-c9b9-4bcf-b05f-388fe35c794d"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "ПК101" },
                    { new Guid("a77de888-4132-4f2c-b0f7-bb7ffac78bf0"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "ЦК 301 Р" }
                });

            migrationBuilder.InsertData(
                table: "TechnologicalPositions",
                columns: new[] { "Id", "InstalationId", "Name" },
                values: new object[,]
                {
                    { new Guid("ab117d29-20b6-400a-9747-0f8d1b8d098f"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "Н102-P" },
                    { new Guid("ace79e04-4547-4161-8212-dda77d678a42"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "ЦП 4" },
                    { new Guid("c36b152f-e0e7-47b6-8776-ca90537b3b59"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "Н 109-Р" },
                    { new Guid("cd394570-be68-4b7f-8ee3-d9dc13caaf60"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "ЦП1" },
                    { new Guid("d926a392-d513-45a2-ada8-fe5a05ece6eb"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "ЦК 301" },
                    { new Guid("e4914783-4d0f-4afa-b34e-9cbbf7953558"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "Н102-2" },
                    { new Guid("f48f6af8-4aa4-423f-b24f-9fbdfc4b0b39"), new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "Н102-1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("822edebf-23a5-4373-b56d-94078d984192") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("ecd856e4-96da-4296-a482-6f66680f1380") });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("ecd856e4-96da-4296-a482-6f66680f1380") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f91c5b35-506c-4987-a89a-fba703b53f03"));

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 6, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 6, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 6, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 6, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 6, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 6, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 6, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 6, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 6, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 6, 29, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 6, 29, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 6, 29, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 6, 29, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 6, 29, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 6, 29, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 6, 29, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 6, 29, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 6, 29, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 6, 30, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 6, 30, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 6, 30, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 6, 30, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 6, 30, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 6, 30, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 6, 30, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 6, 30, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 6, 30, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 1, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 1, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 1, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 1, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 1, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 1, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 1, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 1, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 1, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 2, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 2, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 2, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 2, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 2, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 2, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 2, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 2, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 2, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 3, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 4, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 4, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 4, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 4, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 4, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 4, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 4, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 4, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 4, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 5, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 5, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 5, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 5, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 5, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 5, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 5, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 5, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 5, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 6, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 6, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 6, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 6, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 6, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 6, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 6, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 6, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 6, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 7, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 7, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 7, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 7, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 7, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 7, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 7, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 7, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 7, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 8, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 8, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 8, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 8, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 8, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 8, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 8, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 8, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 8, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 9, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 9, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 9, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 9, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 9, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 9, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 9, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 9, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 9, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 10, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 10, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 10, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 10, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 10, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 10, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 10, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 10, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 10, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 11, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 11, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 11, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 11, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 11, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 11, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 11, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 11, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 11, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 12, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 12, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 12, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 12, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 12, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 12, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 12, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 12, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 12, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 13, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 13, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 13, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 13, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 13, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 13, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 13, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 13, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 13, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 14, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 14, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 14, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 14, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 14, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 14, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 14, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 14, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 14, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 15, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 15, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 15, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 15, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 15, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 15, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 15, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 15, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 15, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 16, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 16, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 16, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 16, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 16, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 16, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 16, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 16, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 16, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 17, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 17, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 17, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 17, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 17, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 17, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 17, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 17, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 17, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 18, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 18, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 18, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 18, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 18, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 18, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 18, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 18, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 18, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 19, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 19, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 19, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 19, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 19, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 19, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 19, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 19, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 19, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 20, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 20, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 20, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 20, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 20, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 20, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 20, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 20, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 20, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 21, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 21, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 21, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 21, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 21, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 21, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 21, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 21, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 21, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 22, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 22, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 22, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 22, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 22, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 22, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 22, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 22, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 22, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 23, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 23, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 23, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 23, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 23, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 23, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 23, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 23, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 23, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 24, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 24, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 24, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 24, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 24, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 24, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 24, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 24, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 24, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 25, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 25, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 25, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 25, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 25, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 25, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 25, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 25, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 25, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 26, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 26, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 26, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 26, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 26, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 26, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 26, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 26, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 26, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 27, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 27, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 27, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 27, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 27, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 27, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 27, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 27, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 27, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 28, 19, 27, 36, 952, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.DeleteData(
                table: "PlantInstalations",
                keyColumn: "Id",
                keyValue: new Guid("0c3d7329-a0af-45ee-8ba2-4ac6b0320e3e"));

            migrationBuilder.DeleteData(
                table: "PlantInstalations",
                keyColumn: "Id",
                keyValue: new Guid("0d5fc355-ba0d-494e-aa2d-421616e9f651"));

            migrationBuilder.DeleteData(
                table: "PlantInstalations",
                keyColumn: "Id",
                keyValue: new Guid("1b3e962a-ab8f-4fec-87d3-3221edb3bad0"));

            migrationBuilder.DeleteData(
                table: "PlantInstalations",
                keyColumn: "Id",
                keyValue: new Guid("27e67a5e-9def-417e-b479-a3374ac01357"));

            migrationBuilder.DeleteData(
                table: "PlantInstalations",
                keyColumn: "Id",
                keyValue: new Guid("35dbc6f8-e63e-46a5-98ec-305161eca10f"));

            migrationBuilder.DeleteData(
                table: "PlantInstalations",
                keyColumn: "Id",
                keyValue: new Guid("38a9c7f5-45b6-4783-a1ba-365f22cb8cea"));

            migrationBuilder.DeleteData(
                table: "PlantInstalations",
                keyColumn: "Id",
                keyValue: new Guid("439d96e7-35fd-4037-a88e-ac56dd11e9d8"));

            migrationBuilder.DeleteData(
                table: "PlantInstalations",
                keyColumn: "Id",
                keyValue: new Guid("4dabf64e-adb1-486a-b208-b07c5fabc440"));

            migrationBuilder.DeleteData(
                table: "PlantInstalations",
                keyColumn: "Id",
                keyValue: new Guid("50465de6-39bd-4370-9e51-b7f60f56130a"));

            migrationBuilder.DeleteData(
                table: "PlantInstalations",
                keyColumn: "Id",
                keyValue: new Guid("5078a11e-d2b0-40ca-ae46-79d81197af11"));

            migrationBuilder.DeleteData(
                table: "PlantInstalations",
                keyColumn: "Id",
                keyValue: new Guid("7e9d0982-c5fa-493d-b8b1-30babddbdfcc"));

            migrationBuilder.DeleteData(
                table: "PlantInstalations",
                keyColumn: "Id",
                keyValue: new Guid("8b6563b0-5bc0-4778-bc4c-30fa347d9854"));

            migrationBuilder.DeleteData(
                table: "PlantInstalations",
                keyColumn: "Id",
                keyValue: new Guid("c05340da-e358-47f7-822e-bde8030f456a"));

            migrationBuilder.DeleteData(
                table: "PlantInstalations",
                keyColumn: "Id",
                keyValue: new Guid("c639c036-bdc1-4e54-9425-c77ab00658a3"));

            migrationBuilder.DeleteData(
                table: "PlantInstalations",
                keyColumn: "Id",
                keyValue: new Guid("c7d3bad4-cd8c-4a73-a98c-3e57fc04b09d"));

            migrationBuilder.DeleteData(
                table: "PlantInstalations",
                keyColumn: "Id",
                keyValue: new Guid("e90898e2-831b-4266-8d4c-014cffefcf56"));

            migrationBuilder.DeleteData(
                table: "PlantInstalations",
                keyColumn: "Id",
                keyValue: new Guid("e9e9f60a-057a-4105-8adb-b0f4f0fbfcc5"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("0487b9c4-ceca-47d0-9ea5-4ef33d9262c2"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("0c5e037a-4ad6-4ada-a3c8-bf8aa34b90ee"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("0da0c03c-eb4a-44dd-bb47-2438d7cd128b"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("1272bde9-d132-4a76-8be1-da94f41100e6"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("15d1308a-2e55-467c-b251-ee4b38262723"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("1a452cb1-b1d1-4b48-9159-badcc40ba590"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("1b1b7597-8065-4b33-8b7e-eb4fae5d4603"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("2b1bca55-1492-4688-a530-04f88917888b"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("2c107550-7b23-4478-af9b-448d50d65a23"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("3a7e4c0e-6b25-4707-874d-953d619e7d93"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("3e61213e-5e51-4848-a916-51d45fb55dd9"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("465a93ad-50e3-4b59-991a-1b9d1c04cf4e"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("6cc1db50-1604-4e5a-94de-cc3087cee06e"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("6e7763d6-a561-4407-b95a-bcc0ec3ec42b"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("7fcd955b-a234-4f5e-bb1d-68afd2374038"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("936edbb9-9444-44cd-89f3-80fb27d70e9a"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("9ed832f2-c9b9-4bcf-b05f-388fe35c794d"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("a77de888-4132-4f2c-b0f7-bb7ffac78bf0"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("ab117d29-20b6-400a-9747-0f8d1b8d098f"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("ace79e04-4547-4161-8212-dda77d678a42"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("c36b152f-e0e7-47b6-8776-ca90537b3b59"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("cd394570-be68-4b7f-8ee3-d9dc13caaf60"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("d926a392-d513-45a2-ada8-fe5a05ece6eb"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("e4914783-4d0f-4afa-b34e-9cbbf7953558"));

            migrationBuilder.DeleteData(
                table: "TechnologicalPositions",
                keyColumn: "Id",
                keyValue: new Guid("f48f6af8-4aa4-423f-b24f-9fbdfc4b0b39"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("822edebf-23a5-4373-b56d-94078d984192"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ecd856e4-96da-4296-a482-6f66680f1380"));

            migrationBuilder.DeleteData(
                table: "PlantInstalations",
                keyColumn: "Id",
                keyValue: new Guid("13d901bf-8203-4280-ae70-24eef3fed196"));

            migrationBuilder.DeleteData(
                table: "PlantInstalations",
                keyColumn: "Id",
                keyValue: new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"));

            migrationBuilder.DeleteData(
                table: "ProductionComplexes",
                keyColumn: "Id",
                keyValue: new Guid("125b8f04-7c38-4d1b-b39e-6d750e7bd037"));

            migrationBuilder.DeleteData(
                table: "ProductionComplexes",
                keyColumn: "Id",
                keyValue: new Guid("79afcb01-d8f3-4fe0-9fa2-fd95b72c615f"));

            migrationBuilder.DeleteData(
                table: "ProductionComplexes",
                keyColumn: "Id",
                keyValue: new Guid("bd922bb0-94af-4bf0-9a99-2431661a27b6"));

            migrationBuilder.DeleteData(
                table: "ProductionComplexes",
                keyColumn: "Id",
                keyValue: new Guid("fe306aa1-f678-4e94-9d86-308ed58fd305"));

            migrationBuilder.DeleteData(
                table: "WorkingShifts",
                keyColumn: "Id",
                keyValue: new Guid("51e3023b-5967-4221-ba1e-977fdff10eda"));

            migrationBuilder.DeleteData(
                table: "WorkingShifts",
                keyColumn: "Id",
                keyValue: new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d"));

            migrationBuilder.DeleteData(
                table: "WorkingShifts",
                keyColumn: "Id",
                keyValue: new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2"));

            migrationBuilder.DeleteData(
                table: "ProductionComplexes",
                keyColumn: "Id",
                keyValue: new Guid("d90ccba2-389c-4a1a-ac97-5c54340dadd4"));
        }
    }
}
