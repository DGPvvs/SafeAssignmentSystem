using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafeAssignmentSystem.DataBase.Migrations
{
    public partial class SeedTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserWorkNumber" },
                values: new object[,]
                {
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", 0, "623505aa-bf9c-432f-b384-fdcc6ebf129c", null, false, "Столипен", "Тонев", false, null, null, "STOLIPEN.TONEV", "AQAAAAEAACcQAAAAECubnelZlTaRGg8kvHctqfqBndYqhhzPb3hcRT0TDSlThqXRTT/9hd7NCElgyn+8mg==", null, false, "9315b09e-4bc2-4010-a156-4beb452660fc", false, "Stolipen.Tonev", 38744 },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", 0, "89610bd3-7092-4c0e-a11e-bf2cee2ff28d", null, false, "Жерар", "Славчев", false, null, null, "GERAR.SLAVTCHEV", "AQAAAAEAACcQAAAAEKoWqvFEzz0/ylck2cCEes7tCoGQnJ610EQ6MBzq6iW9bbYSa+CaZU67q/Ak2189NA==", null, false, "ba172f7e-d261-4a01-ac09-2a4b4030f240", false, "Gerar.Slavtchev", 45571 },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", 0, "b5cab136-3b3e-4738-8323-f28b1e1fbaf1", null, false, "Лазо", "Шишманов", false, null, null, "LAZO.CHICHMANOV", "AQAAAAEAACcQAAAAEDYNEuBt9nauspEyOWfUvuNJFWQHKAoL1jWW/MvfdkmyYc8XR9vfVAPRGWXY+oHuVw==", null, false, "11be1730-5b54-4e7a-ab1f-c6b6070ffa1d", false, "Lazo.Chichmanov", 68340 },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", 0, "b60a2072-d17b-4f53-a3a1-152b91b71850", null, false, "Дан", "Игнатов", false, null, null, "IGNATOV.DAN", "AQAAAAEAACcQAAAAEEuTXcaEPxeXelN/Wmi00L7muqFS/KDV/wkbr7TZo77I6apJyQ1Hfm1fQeH/t08dAg==", null, false, "a156c966-4817-47c7-8594-29bd2a5971d7", false, "Ignatov.Dan", 88327 },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", 0, "3d9d7daa-6582-4b34-bb7a-7481cd94b86d", null, false, "Флоро", "Станов", false, null, null, "FLORO.STANOV", "AQAAAAEAACcQAAAAEOI7NR6c6dip7aaAfE2R6Fwf/VRgAbb+LZxsJTEwxHP9+vduaWoZ+rnjVH//heNbgA==", null, false, "4f41d18d-5f46-4f1c-83d3-c3a5825dc1c4", false, "Floro.Stanov", 71417 },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", 0, "cfd24f04-ed46-4b58-9fff-9587d75ba00d", null, false, "Руси", "Магичов", false, null, null, "RUSI.MAGITCHOV", "AQAAAAEAACcQAAAAEELnUr2XUy2b5iPkYRMFHyaGMNG0gev9yfV0lDic9glJrBB1TcyjyTRWVf/ksdwklQ==", null, false, "aebd5976-380c-4129-80f6-815036c2f65a", false, "Rusi.Magitchov", 44454 },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", 0, "4ec89721-d197-4c2e-9dc5-9a964db64dc2", null, false, "Дарен", "Павков", false, null, null, "DAREN.PAVKOV", "AQAAAAEAACcQAAAAEHlzFAFoGOmJxBW6i+ArVWSJu3WEVT9O83o49QztyaG8oBWj9QwFPaahEwtbK/C/Sw==", null, false, "c6ed3db1-c807-4881-9a07-afad40740e3b", false, "Daren.Pavkov", 98129 },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", 0, "62fb5801-1ef8-442b-b411-bd648b1ae1c9", null, false, "Данимил", "Тинков", false, null, null, "DANIMIL.TINKOV", "AQAAAAEAACcQAAAAEJq+fL2sY2RutywC7ZVEUeBGOFM5zss4vYrEdI/aNqR/b5aE4pKqNW8bWL3XcsdkcQ==", null, false, "1d2e0af5-f870-40f6-9ce6-b84338fc6b75", false, "Danimil.Tinkov", 70677 },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", 0, "cc2643d2-3951-4b99-91fd-78db8fff5c9a", null, false, "Сергей", "Попов", false, null, null, "POPOV.SERGEY", "AQAAAAEAACcQAAAAEBNitQEf+6Sd/XIBQBDl+yLzRBaXv8gRXz1ac+7vYtFUxFcbbfNLLZWM9tpAQdbStw==", null, false, "19a9f1d9-a903-4cbc-88bb-8944284a586f", false, "Popov.Sergey", 38011 },
                    { "822edebf-23a5-4373-b56d-94078d984192", 0, "b59f556e-5288-4a37-9104-09e5033a944e", null, false, "Пейо", "Ленков", false, null, null, "PEYO.LENKOV", "AQAAAAEAACcQAAAAEG61RclPe+0hT/OeOYy4F2CFPVJDgTroMpBmgr/oN5fgWf7QwjVvr7MAtR0N6nY6fw==", null, false, "03b2c16e-f92f-4146-b661-7b9dd7be3acc", false, "Peyo.Lenkov", 62230 },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", 0, "4157b08b-383d-4a5e-a919-c453d50f2272", null, false, "Аню", "Панчев", false, null, null, "ANUY.PANTCHEV", "AQAAAAEAACcQAAAAENQsFwO8Q7OXsgk+P8aBzEVLL7mRa8+sEsdttiELuy6ZNTssvrpZH0lSFpTdDstmOA==", null, false, "aa146c2c-9d75-44e0-aefb-5b2aed095d39", false, "Anuy.Pantchev", 65072 },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", 0, "da78c4bb-e122-46f6-a2ed-81acfe3f1ac4", null, false, "Друмчо", "Светозаров", false, null, null, "DRUMTCHO.SVETOZAROV", "AQAAAAEAACcQAAAAEPhg7BMsG3Jp0xZMKvKNYI+kkOEhj6M6PoMjMCKxe/JGc9GbeIxavkUD+Fhs5zTUdA==", null, false, "bfa26d44-5bb3-4572-a49a-ab7aa09f54f6", false, "Drumtcho.Svetozarov", 35236 },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", 0, "b9506203-4c3e-43ff-bd9a-e75966b9785d", null, false, "Дориян", "Славейков", false, null, null, "DORIYAN.SLAVEYKOV", "AQAAAAEAACcQAAAAEJHSbu3cERfAEAMti3tI4YGGpXxnyLnvgzTIA8fe81QMVLsGwEDZ6xUmYJmZ0nXjWQ==", null, false, "4b79a67b-6609-495c-9e37-9b62d795dd11", false, "Doriyan.Slaveykov", 39676 },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", 0, "9694bf71-6284-45a3-9282-22e109bc1ada", null, false, "Менко", "Мирков", false, null, null, "MENKO.MIRKOV", "AQAAAAEAACcQAAAAEB8vFOP/G6QfyCaguTaS/StHlZujcGceBJN0KPZNkCwbXGjddMDsF35/QaSKMawm6A==", null, false, "567f707b-51a1-41f0-a588-a1bd9bfa320a", false, "Menko.Mirkov", 19386 },
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", 0, "d1870ed5-0c7d-4d95-87b0-0283777124d9", null, false, "Силвиян", "Янов", false, null, null, "SILVIYAN.YANKOV", "AQAAAAEAACcQAAAAEEwyu34l2oAN86lf9ozzVkbCFdKr8y1E1SmEEZMdt8jStrrxpSHKppMXO7dG8SElKQ==", null, false, "89e518c6-5b9e-4553-9d59-391b8d733066", false, "Silviyan.Yankov", 52291 },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", 0, "f54afaec-bbb4-4e08-81bb-164de12acadd", null, false, "Драгни", "Тодоров", false, null, null, "DRAGNI.TODOROV", "AQAAAAEAACcQAAAAEElcx/B24MlYLuNBeMnXrMyVyJii84AikvV1c76j2eBwUrshj5ktVlpL77xOpjaysQ==", null, false, "c166796c-a5c7-4df6-af62-b721ca2aabe6", false, "Dragni.Todorov", 80738 },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", 0, "4d342e83-fbee-4db9-8c76-d2ba99937fb6", null, false, "Доко", "Цанимиров", false, null, null, "DOKO.TSANIMIROV", "AQAAAAEAACcQAAAAEBG1FAE85AMpmDG/NwsQ0t12pIIpqPg5YgoUbCnIv76ITyyZZbqboQoga3Jt6cP6GQ==", null, false, "c03cce7d-85c0-4775-b666-6336c8166f7b", false, "Doko.Tsanimirov", 46929 },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", 0, "c73c302a-3c8d-4ecc-b888-0b3529c17a6e", null, false, "Биню", "Тошков", false, null, null, "BINUY.TOCHKOV", "AQAAAAEAACcQAAAAEEFTJSJHJgBjHBNl8s8nSIeCJaP1Y/VvfCp0o8vJz9DMbHzZqhjJ78LTKvPefxLTfA==", null, false, "8d8c822c-e6e3-4c08-8aa1-f5def9f96ac9", false, "Binuy.Tochkov", 61815 },
                    { "f91c5b35-506c-4987-a89a-fba703b53f03", 0, "d33637a7-45c3-4978-9742-e645d3413140", null, false, "Захари", "Тодеев", false, null, null, "ZAHARI.TODEEV", "AQAAAAEAACcQAAAAEN+rtVWAtD5IxkJUSAKPBpApQyNKD/C6wuFHqqX3hY34MFzR9hJ2iE/DVtAjf6G2sw==", null, false, "ed880f06-04c0-482b-9795-6366e1dd6847", false, "Zahari.Todeev", 50975 }
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
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 6, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 6, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 6, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 6, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 6, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 6, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 6, 26, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 6, 26, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 26, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 26, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 26, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 6, 26, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 6, 26, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 6, 26, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 6, 26, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 6, 27, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 6, 27, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 6, 27, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 27, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 6, 27, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 27, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 27, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 6, 27, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 6, 27, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 6, 28, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 6, 28, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 6, 28, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 6, 28, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 28, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 6, 28, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 6, 28, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 28, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 28, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 6, 29, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 6, 29, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 6, 29, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 29, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 6, 29, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 6, 29, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 29, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 29, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 6, 29, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 1, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 1, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 1, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 1, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 1, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 1, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 1, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 1, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 1, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 2, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 2, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 2, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 2, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 2, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 2, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 2, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 2, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 2, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 3, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 3, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 3, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 3, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 3, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 3, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 3, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 3, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 3, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 4, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 4, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 4, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 4, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 4, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 4, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 4, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 4, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 4, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 5, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 5, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 5, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 5, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 5, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 5, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 5, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 5, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 5, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 6, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 6, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 6, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 6, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 6, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 6, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 6, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 6, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 6, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 7, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 7, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 7, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 7, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 7, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 7, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 7, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 7, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 7, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 8, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 8, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 8, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 8, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 8, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 8, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 8, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 8, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 8, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 9, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 9, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 9, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 9, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 9, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 9, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 9, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 9, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 9, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 10, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 10, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 10, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 10, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 10, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 10, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 10, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 10, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 10, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 11, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 11, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 11, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 11, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 11, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 11, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 11, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 11, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 11, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 12, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 12, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 12, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 12, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 12, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 12, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 12, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 12, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 12, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 13, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 13, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 13, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 13, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 13, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 13, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 13, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 13, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 13, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 14, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 14, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 14, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 14, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 14, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 14, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 14, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 14, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 14, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 15, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 15, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 15, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 15, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 15, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 15, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 15, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 15, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 15, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 16, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 16, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 16, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 16, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 16, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 16, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 16, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 16, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 16, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 17, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 17, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 17, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 17, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 17, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 17, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 17, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 17, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 17, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 18, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 18, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 18, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 18, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 18, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 18, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 18, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 18, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 18, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 19, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 19, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 19, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 19, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 19, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 19, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 19, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 19, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 19, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 20, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 20, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 20, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 20, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 20, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 20, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 20, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 20, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 20, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 21, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 21, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 21, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 21, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 21, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 21, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 21, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 21, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 21, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 22, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 22, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 22, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 22, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 22, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 22, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 22, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 22, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 22, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 23, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 23, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 23, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 23, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 23, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 23, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 23, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 23, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 23, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 24, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 24, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 24, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 24, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 24, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 24, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 24, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 24, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 24, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
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
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "15116ebd-a590-489b-96f3-f4b87352ceb3", true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "15116ebd-a590-489b-96f3-f4b87352ceb3", true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "291a943f-27f5-45ec-b38a-c97f4e2cba89", true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "3bd76d51-384b-4233-a83e-40e1e1a355dc", true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "3bd76d51-384b-4233-a83e-40e1e1a355dc", true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "3e3070f2-48d9-4aa4-a760-5654f7d59b14", true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "46704eca-2943-4635-ae5b-0b9a4a9fa274", true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "46704eca-2943-4635-ae5b-0b9a4a9fa274", true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "68c22160-dd62-44e3-b9fa-a5285aeed74a", true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "6a1a286e-7523-4b64-bec5-a5350b4f8169", true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "6a1a286e-7523-4b64-bec5-a5350b4f8169", true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "789fd6e8-ea96-4af7-b417-75284395ceeb", true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "789fd6e8-ea96-4af7-b417-75284395ceeb", true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "822edebf-23a5-4373-b56d-94078d984192", true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "878d9e51-f7c1-4460-b502-6d3611acc9de", true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "984b9932-5e9b-4bc9-a923-4099f7d488b2", true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "b5459434-2a22-47eb-b993-775edc6f4bf1", true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "cb0d669c-0739-46cb-af7e-135b3c1359ab", true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "dc64720a-db37-48a3-b0d9-da13abec71f7", true },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "ecd856e4-96da-4296-a482-6f66680f1380", true },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "ecd856e4-96da-4296-a482-6f66680f1380", true }
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
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "08972cfc-c9f9-40fd-8bd9-5cb1a2137512" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "15116ebd-a590-489b-96f3-f4b87352ceb3" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "15116ebd-a590-489b-96f3-f4b87352ceb3" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "291a943f-27f5-45ec-b38a-c97f4e2cba89" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "3bd76d51-384b-4233-a83e-40e1e1a355dc" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "3bd76d51-384b-4233-a83e-40e1e1a355dc" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "3e3070f2-48d9-4aa4-a760-5654f7d59b14" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "46704eca-2943-4635-ae5b-0b9a4a9fa274" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "46704eca-2943-4635-ae5b-0b9a4a9fa274" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "68c22160-dd62-44e3-b9fa-a5285aeed74a" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "6a1a286e-7523-4b64-bec5-a5350b4f8169" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "6a1a286e-7523-4b64-bec5-a5350b4f8169" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "789fd6e8-ea96-4af7-b417-75284395ceeb" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "789fd6e8-ea96-4af7-b417-75284395ceeb" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "822edebf-23a5-4373-b56d-94078d984192" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "878d9e51-f7c1-4460-b502-6d3611acc9de" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "984b9932-5e9b-4bc9-a923-4099f7d488b2" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "b5459434-2a22-47eb-b993-775edc6f4bf1" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "c6f014d9-2816-4d1d-961f-9d313dbeb2ea" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "cb0d669c-0739-46cb-af7e-135b3c1359ab" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "d5ebbc22-5405-4a37-94d5-b76cb8dd489a" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "dc64720a-db37-48a3-b0d9-da13abec71f7" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), "ecd856e4-96da-4296-a482-6f66680f1380" });

            migrationBuilder.DeleteData(
                table: "ApplicationUserPlantInstalations",
                keyColumns: new[] { "InstalationId", "UserId" },
                keyValues: new object[] { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), "ecd856e4-96da-4296-a482-6f66680f1380" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f91c5b35-506c-4987-a89a-fba703b53f03");

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 6, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 6, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 6, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 6, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 6, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 6, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 6, 26, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 6, 26, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 26, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 26, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 26, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 6, 26, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 6, 26, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 6, 26, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 6, 26, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 6, 27, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 6, 27, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 6, 27, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 27, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 6, 27, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 27, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 27, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 6, 27, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 6, 27, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 6, 28, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 6, 28, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 6, 28, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 6, 28, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 28, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 6, 28, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 6, 28, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 28, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 28, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 6, 29, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 6, 29, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 6, 29, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 29, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 6, 29, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 6, 29, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 29, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 29, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 6, 29, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 6, 30, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 1, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 1, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 1, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 1, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 1, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 1, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 1, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 1, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 1, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 2, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 2, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 2, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 2, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 2, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 2, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 2, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 2, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 2, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 3, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 3, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 3, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 3, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 3, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 3, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 3, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 3, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 3, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 4, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 4, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 4, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 4, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 4, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 4, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 4, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 4, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 4, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 5, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 5, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 5, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 5, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 5, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 5, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 5, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 5, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 5, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 6, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 6, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 6, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 6, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 6, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 6, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 6, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 6, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 6, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 7, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 7, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 7, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 7, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 7, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 7, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 7, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 7, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 7, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 8, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 8, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 8, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 8, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 8, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 8, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 8, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 8, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 8, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 9, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 9, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 9, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 9, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 9, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 9, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 9, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 9, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 9, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 10, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 10, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 10, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 10, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 10, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 10, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 10, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 10, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 10, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 11, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 11, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 11, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 11, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 11, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 11, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 11, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 11, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 11, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 12, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 12, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 12, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 12, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 12, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 12, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 12, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 12, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 12, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 13, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 13, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 13, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 13, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 13, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 13, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 13, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 13, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 13, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 14, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 14, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 14, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 14, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 14, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 14, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 14, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 14, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 14, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 15, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 15, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 15, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 15, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 15, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 15, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 15, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 15, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 15, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 16, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 16, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 16, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 16, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 16, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 16, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 16, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 16, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 16, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 17, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 17, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 17, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 17, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 17, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 17, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 17, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 17, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 17, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 18, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 18, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 18, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 18, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 18, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 18, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 18, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 18, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 18, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 19, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 19, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 19, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 19, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 19, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 19, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 19, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 19, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 19, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 20, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 20, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 20, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 20, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 20, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 20, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 20, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 20, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 20, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 21, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 21, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 21, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 21, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 21, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 21, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 21, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 21, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 21, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 22, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 22, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 22, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 22, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 22, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 22, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 22, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 22, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 22, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 23, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 23, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 23, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 23, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 23, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 23, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 23, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 23, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 23, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 24, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 24, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 24, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 24, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 24, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 24, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 24, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 24, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 24, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 25, 22, 21, 49, 9, DateTimeKind.Local).AddTicks(8995) });

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
                keyValue: "08972cfc-c9f9-40fd-8bd9-5cb1a2137512");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15116ebd-a590-489b-96f3-f4b87352ceb3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "291a943f-27f5-45ec-b38a-c97f4e2cba89");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3bd76d51-384b-4233-a83e-40e1e1a355dc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e3070f2-48d9-4aa4-a760-5654f7d59b14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46704eca-2943-4635-ae5b-0b9a4a9fa274");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68c22160-dd62-44e3-b9fa-a5285aeed74a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a1a286e-7523-4b64-bec5-a5350b4f8169");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "789fd6e8-ea96-4af7-b417-75284395ceeb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "822edebf-23a5-4373-b56d-94078d984192");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "878d9e51-f7c1-4460-b502-6d3611acc9de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "984b9932-5e9b-4bc9-a923-4099f7d488b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5459434-2a22-47eb-b993-775edc6f4bf1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6f014d9-2816-4d1d-961f-9d313dbeb2ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb0d669c-0739-46cb-af7e-135b3c1359ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5ebbc22-5405-4a37-94d5-b76cb8dd489a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc64720a-db37-48a3-b0d9-da13abec71f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ecd856e4-96da-4296-a482-6f66680f1380");

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
