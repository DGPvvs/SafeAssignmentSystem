using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafeAssignmentSystem.DataBase.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserWorkNumber" },
                values: new object[,]
                {
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", 0, "f1110da7-0b56-4fe9-be57-d1a3aed457ff", null, false, "Столипен", "Тонев", false, null, null, "STOLIPEN.TONEV", "AQAAAAEAACcQAAAAEGrZKLWAydCLbEVWrbBgTaPfk/ejKVRCFLcB9kiYvXWerFTwP44Nu7pZaX/2dOGgqA==", null, false, "2a5b074d-f9a5-4f36-a56f-4a6c70156635", false, "Stolipen.Tonev", 38744 },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", 0, "7dcdb67a-f7f6-48ec-9579-f6b272469f7f", null, false, "Жерар", "Славчев", false, null, null, "GERAR.SLAVTCHEV", "AQAAAAEAACcQAAAAEIki15ExwN4+Xxaqqt/p8dzTKYkx4oavy9e6Gu2Onf0QYRtKuLe4xC7X34hYuZSV1g==", null, false, "979049e2-2812-46ea-8b51-27bead1be825", false, "Gerar.Slavtchev", 45571 },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", 0, "fb6094db-9540-4eb0-9034-9392b48923a1", null, false, "Лазо", "Шишманов", false, null, null, "LAZO.CHICHMANOV", "AQAAAAEAACcQAAAAEISMGHdTNM77HPBid+Q6K11Gxy5DpPQo2gU8ZdHqX53kKizaqU3YHQu5XDSeRDKP2A==", null, false, "5ade7d20-9ab4-4487-be22-5eeb096180b0", false, "Lazo.Chichmanov", 68340 },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", 0, "8e47720f-cd2a-4ebe-983c-23fafcafa123", null, false, "Дан", "Игнатов", false, null, null, "IGNATOV.DAN", "AQAAAAEAACcQAAAAEJ7ztXlWm5yH5Xxa/uwrNKea+Zb3n0hbXYOCSmhJaAr+fMmY3n206yLHpf3N8k7ykQ==", null, false, "a1b2639e-eeb0-482f-a75d-ea90b86540b2", false, "Ignatov.Dan", 88327 },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", 0, "0c444284-cab4-49e3-8d7e-e42857d56193", null, false, "Флоро", "Станов", false, null, null, "FLORO.STANOV", "AQAAAAEAACcQAAAAENXtCIqWGYKhdvPpvs3uJzkUWTilCukBjscu7AGVgzhPA9/XIMCjyhYISXDCj7Suag==", null, false, "71e4e5f5-bbd3-428a-93dd-bda75901a0d3", false, "Floro.Stanov", 71417 },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", 0, "7a3afe9b-4e77-4cb3-8193-430e327cbb7b", null, false, "Руси", "Магичов", false, null, null, "RUSI.MAGITCHOV", "AQAAAAEAACcQAAAAENoRoa7LZggYrD9yhhWbXtUbGQ9voN+YJ+XPSogVmVDTUkAYFw0ujq2m4d96vIAfNg==", null, false, "ff650029-1fc5-4a49-be34-7626de457a3d", false, "Rusi.Magitchov", 44454 },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", 0, "fb2381bf-4527-4b09-8cae-4edcbd5294b7", null, false, "Дарен", "Павков", false, null, null, "DAREN.PAVKOV", "AQAAAAEAACcQAAAAEMScqvh4rMWuMpMd3iOcuN9j3eswSYifeegJkcGj79VNC4uVPqYPhg1vGmoiqPHgNw==", null, false, "926aa08a-072b-4aea-b41f-e79e3069076a", false, "Daren.Pavkov", 98129 },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", 0, "691d805f-efca-4258-b09d-58f99374f8dc", null, false, "Данимил", "Тинков", false, null, null, "DANIMIL.TINKOV", "AQAAAAEAACcQAAAAEKiGp0Jae1IBZRmynqWgPgqUddfxw0RrcVEjzjDc0CaL7MJ/zUcr3uapNIXrKRRstA==", null, false, "94e93252-35d1-42fd-955c-245541d546f2", false, "Danimil.Tinkov", 70677 },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", 0, "fb93186c-c1f9-42aa-ba90-9716f09f50a5", null, false, "Сергей", "Попов", false, null, null, "POPOV.SERGEY", "AQAAAAEAACcQAAAAEBOaJs5emgBtm6hN771rAl70Kp3YN9oOGYzGkW2y3jGc9nIJdUkkxDUPyWqV5oRdPA==", null, false, "85521765-ff57-4b5d-92d3-5f849b1db7f6", false, "Popov.Sergey", 38011 },
                    { "822edebf-23a5-4373-b56d-94078d984192", 0, "408a0bff-b756-4872-b092-a517daa5ddfa", null, false, "Пейо", "Ленков", false, null, null, "PEYO.LENKOV", "AQAAAAEAACcQAAAAEFKsYLvn2cwf4myfFgxNYf74qCBu+3qvU5ZG0dnuZ1cca3hwQ4IJE2aclxft4luuHg==", null, false, "60c0dffe-b7f0-4ec0-ab36-d1a1a8073e3c", false, "Peyo.Lenkov", 62230 },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", 0, "270fd0ff-0bbc-4dc4-bf95-0d96a714d11b", null, false, "Аню", "Панчев", false, null, null, "ANUY.PANTCHEV", "AQAAAAEAACcQAAAAEBWpRD6tsMK1JBm5HWQDz0vTDfIci+d/sZWQIuz8x5CpPAfMYUktjFAFx5PPjt1QeA==", null, false, "6a1f6fee-6068-491a-8707-d625e1e12f9a", false, "Anuy.Pantchev", 65072 },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", 0, "e0b77310-1712-4bea-b4df-2c9b800ca568", null, false, "Друмчо", "Светозаров", false, null, null, "DRUMTCHO.SVETOZAROV", "AQAAAAEAACcQAAAAEC4akA3Pa9q+wYbLuN/xjjgUVPsMmORuxQzGmJUhS4pj8gSbaolMIRj46GqIq5SxKA==", null, false, "fe71b2d8-adda-49c7-a5e6-46f16b59c8b1", false, "Drumtcho.Svetozarov", 35236 },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", 0, "fd059f17-cfc2-4919-8d20-6f6c33d631ca", null, false, "Дориян", "Славейков", false, null, null, "DORIYAN.SLAVEYKOV", "AQAAAAEAACcQAAAAEMZrYzvOa0Txkb4NKI7M1aKT4zV0wTko7K1V/HQ6zg7TzSi4+In9xo45MjDNtwELsg==", null, false, "1aa52ee1-ccb6-4e96-bb9b-adf0f37c7f75", false, "Doriyan.Slaveykov", 39676 },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", 0, "4c7df92d-b3d2-4258-be86-d9d410c4e670", null, false, "Менко", "Мирков", false, null, null, "MENKO.MIRKOV", "AQAAAAEAACcQAAAAEKHjqKKJHqoaZW8H33/dC7NhJjrUrAmf98mEfphT6E2ga40zA35tGwNWDD5le9QF2w==", null, false, "6616b018-9a4d-498b-8273-571a4379a37c", false, "Menko.Mirkov", 19386 },
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", 0, "e217943c-28d3-4eeb-9db8-f21967eee65d", null, false, "Силвиян", "Янов", false, null, null, "SILVIYAN.YANKOV", "AQAAAAEAACcQAAAAEH5icSsS0aOSqmIrqASNjFsqB7Xys5iKNsNUX3XnE3p+ZEXT5gldeS1FPh80alIfeA==", null, false, "56fea898-8e34-4206-a033-e92ea63f98eb", false, "Silviyan.Yankov", 52291 },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", 0, "c7a752ad-dbd0-4692-b23a-f23bd36242a2", null, false, "Драгни", "Тодоров", false, null, null, "DRAGNI.TODOROV", "AQAAAAEAACcQAAAAEGwj8oQUW0EEGuBScW7qbbrk/QdK5Wp2pD9YWxFg93qlQtxmOy1Z9bFxFl+DN3ajbQ==", null, false, "4a651db2-27e0-40b0-9017-cd1d5ae29f8f", false, "Dragni.Todorov", 80738 },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", 0, "9901f9c1-0d05-42aa-a148-c51e02a55ca8", null, false, "Доко", "Цанимиров", false, null, null, "DOKO.TSANIMIROV", "AQAAAAEAACcQAAAAENAy4YHET4vQ0s+IDu3UzXXKFm5yaGaxxEQdMnsGELPVnmZh0eHUxQRdnsi873ODNA==", null, false, "6ecb928f-5aac-468c-a1c6-6f4cbb4a01f4", false, "Doko.Tsanimirov", 46929 },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", 0, "c9b13c6a-efad-4716-adb6-980ebb67f923", null, false, "Биню", "Тошков", false, null, null, "BINUY.TOCHKOV", "AQAAAAEAACcQAAAAEK1BLwNi9cAPeZXQggAbvKKHiyKxgVbTP78zB8NTRRntNiQYz5IkTXpEX+W0/t9Rzw==", null, false, "88bf9188-36f6-4080-9621-f27455b6e5bd", false, "Binuy.Tochkov", 61815 },
                    { "f91c5b35-506c-4987-a89a-fba703b53f03", 0, "c260d7e0-5fb7-4673-96ab-8fd6fd2690e4", null, false, "Захари", "Тодеев", false, null, null, "ZAHARI.TODEEV", "AQAAAAEAACcQAAAAELrwOnIpcxmXy4f3WQci3hPpiXhpPv2/S5NBIOXQE6hchTifCmRH/Gul9T+XL8hYkA==", null, false, "fc21e7ec-1149-4d7a-82ce-03d9ce54ddae", false, "Zahari.Todeev", 50975 }
                });

            migrationBuilder.InsertData(
                table: "ProductionComplexes",
                columns: new[] { "Id", "FullName", "Name" },
                values: new object[,]
                {
                    { new Guid("125b8f04-7c38-4d1b-b39e-6d750e7bd037"), "Енергиен", "Eн" },
                    { new Guid("79afcb01-d8f3-4fe0-9fa2-fd95b72c615f"), "Първична преработка на нефт", "ППН" },
                    { new Guid("bd922bb0-94af-4bf0-9a99-2431661a27b6"), "Полипропилен", "ППр" },
                    { new Guid("d90ccba2-389c-4a1a-ac97-5c54340dadd4"), "Дълбочинна преработка на нефт", "ДПН" },
                    { new Guid("fe306aa1-f678-4e94-9d86-308ed58fd305"), "Транспорт и съхранение на нефтопродукти и Пристанищен Терминал", "ТСНП и ПТ" }
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
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 6, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 6, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 6, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 6, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 6, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 6, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 6, 25, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 6, 25, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 25, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 25, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 25, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 6, 25, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 6, 25, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 6, 25, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 6, 25, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 6, 26, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 6, 26, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 6, 26, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 26, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 6, 26, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 26, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 26, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 6, 26, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 6, 26, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 6, 27, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 6, 27, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 6, 27, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 6, 27, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 27, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 6, 27, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 6, 27, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 27, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 27, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 6, 28, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 6, 28, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 6, 28, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 28, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 6, 28, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 6, 28, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 28, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 28, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 6, 28, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 6, 30, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 30, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 6, 30, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 6, 30, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 30, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 30, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 6, 30, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 6, 30, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 6, 30, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 1, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 1, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 1, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 1, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 1, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 1, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 1, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 1, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 1, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 2, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 2, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 2, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 2, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 2, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 2, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 2, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 2, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 2, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 3, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 3, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 3, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 3, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 3, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 3, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 3, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 3, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 3, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 4, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 4, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 4, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 4, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 4, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 4, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 4, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 4, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 4, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 5, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 5, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 5, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 5, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 5, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 5, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 5, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 5, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 5, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 6, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 6, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 6, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 6, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 6, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 6, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 6, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 6, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 6, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 7, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 7, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 7, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 7, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 7, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 7, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 7, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 7, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 7, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 8, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 8, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 8, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 8, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 8, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 8, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 8, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 8, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 8, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 9, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 9, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 9, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 9, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 9, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 9, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 9, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 9, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 9, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 10, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 10, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 10, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 10, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 10, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 10, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 10, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 10, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 10, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 11, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 11, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 11, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 11, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 11, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 11, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 11, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 11, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 11, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 12, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 12, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 12, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 12, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 12, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 12, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 12, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 12, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 12, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 13, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 13, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 13, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 13, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 13, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 13, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 13, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 13, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 13, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 14, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 14, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 14, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 14, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 14, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 14, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 14, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 14, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 14, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 15, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 15, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 15, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 15, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 15, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 15, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 15, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 15, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 15, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 16, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 16, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 16, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 16, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 16, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 16, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 16, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 16, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 16, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 17, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 17, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 17, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 17, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 17, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 17, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 17, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 17, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 17, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 18, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 18, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 18, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 18, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 18, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 18, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 18, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 18, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 18, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 19, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 19, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 19, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 19, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 19, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 19, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 19, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 19, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 19, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 20, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 20, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 20, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 20, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 20, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 20, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 20, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 20, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 20, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 21, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 21, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 21, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 21, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 21, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 21, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 21, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 21, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 21, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 22, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 22, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 22, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 22, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 22, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 22, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 22, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 22, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 22, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 23, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 23, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 23, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 23, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 23, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 23, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 23, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 23, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 23, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
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
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 6, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 6, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 6, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 6, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 6, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 6, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 6, 25, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 6, 25, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 25, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 25, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 25, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 6, 25, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 6, 25, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 6, 25, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 6, 25, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 6, 26, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 6, 26, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 6, 26, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 26, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 6, 26, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 26, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 26, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 6, 26, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 6, 26, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 6, 27, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 6, 27, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 6, 27, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 6, 27, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 27, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 6, 27, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 6, 27, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 27, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 27, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 6, 28, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 6, 28, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 6, 28, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 28, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 6, 28, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 6, 28, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 28, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 28, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 6, 28, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 6, 29, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 6, 30, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 6, 30, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 6, 30, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 6, 30, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 6, 30, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 6, 30, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 6, 30, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 6, 30, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 6, 30, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 1, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 1, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 1, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 1, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 1, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 1, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 1, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 1, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 1, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 2, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 2, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 2, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 2, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 2, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 2, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 2, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 2, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 2, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 3, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 3, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 3, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 3, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 3, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 3, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 3, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 3, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 3, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 4, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 4, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 4, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 4, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 4, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 4, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 4, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 4, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 4, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 5, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 5, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 5, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 5, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 5, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 5, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 5, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 5, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 5, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 6, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 6, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 6, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 6, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 6, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 6, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 6, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 6, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 6, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 7, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 7, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 7, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 7, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 7, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 7, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 7, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 7, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 7, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 8, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 8, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 8, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 8, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 8, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 8, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 8, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 8, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 8, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 9, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 9, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 9, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 9, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 9, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 9, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 9, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 9, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 9, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 10, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 10, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 10, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 10, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 10, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 10, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 10, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 10, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 10, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 11, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 11, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 11, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 11, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 11, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 11, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 11, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 11, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 11, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 12, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 12, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 12, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 12, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 12, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 12, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 12, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 12, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 12, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 13, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 13, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 13, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 13, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 13, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 13, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 13, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 13, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 13, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 14, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 14, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 14, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 14, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 14, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 14, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 14, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 14, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 14, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 15, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 15, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 15, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 15, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 15, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 15, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 15, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 15, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 15, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 16, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 16, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 16, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 16, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 16, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 16, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 16, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 16, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 16, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 17, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 17, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 17, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 17, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 17, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 17, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 17, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 17, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 17, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 18, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 18, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 18, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 18, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 18, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 18, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 18, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 18, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 18, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 19, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 19, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 19, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 19, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 19, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 19, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 19, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 19, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 19, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 20, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 20, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 20, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 20, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 20, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 20, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 20, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 20, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 20, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", new DateTime(2023, 7, 21, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "15116ebd-a590-489b-96f3-f4b87352ceb3", new DateTime(2023, 7, 21, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 21, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", new DateTime(2023, 7, 21, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 21, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 21, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 21, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 21, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 21, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 22, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 22, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 22, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 22, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 22, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "cb0d669c-0739-46cb-af7e-135b3c1359ab", new DateTime(2023, 7, 22, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", new DateTime(2023, 7, 22, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 22, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "ecd856e4-96da-4296-a482-6f66680f1380", new DateTime(2023, 7, 22, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 23, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "46704eca-2943-4635-ae5b-0b9a4a9fa274", new DateTime(2023, 7, 23, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "68c22160-dd62-44e3-b9fa-a5285aeed74a", new DateTime(2023, 7, 23, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 23, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 23, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 23, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 23, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 23, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "dc64720a-db37-48a3-b0d9-da13abec71f7", new DateTime(2023, 7, 23, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "291a943f-27f5-45ec-b38a-c97f4e2cba89", new DateTime(2023, 7, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "3bd76d51-384b-4233-a83e-40e1e1a355dc", new DateTime(2023, 7, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "6a1a286e-7523-4b64-bec5-a5350b4f8169", new DateTime(2023, 7, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "789fd6e8-ea96-4af7-b417-75284395ceeb", new DateTime(2023, 7, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "822edebf-23a5-4373-b56d-94078d984192", new DateTime(2023, 7, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "878d9e51-f7c1-4460-b502-6d3611acc9de", new DateTime(2023, 7, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "984b9932-5e9b-4bc9-a923-4099f7d488b2", new DateTime(2023, 7, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "b5459434-2a22-47eb-b993-775edc6f4bf1", new DateTime(2023, 7, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", new DateTime(2023, 7, 24, 23, 2, 41, 326, DateTimeKind.Local).AddTicks(9152) });

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
