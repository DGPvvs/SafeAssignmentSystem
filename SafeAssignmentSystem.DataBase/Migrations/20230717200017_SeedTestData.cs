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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("237cb180-758f-465b-8d7d-bff014cf77b8"), "5bdf0b5c-d2ed-4269-9b55-293d0ea69a0b", "NoRole", "NOROLE" },
                    { new Guid("26d978a0-e222-4209-a204-f632f093e657"), "72df0f57-f168-4ac4-8050-978509e0bf63", "Operator", "OPERATOR" },
                    { new Guid("8a08f81e-e7db-44e8-b639-653d22648577"), "23632619-e072-4301-a8ea-ab5a9ae44c1c", "Electrician", "ELECTRICIAN" },
                    { new Guid("b6d9e0b1-7844-40dd-bd53-cee6cf8f3b62"), "a252136c-430c-4e69-aecc-7e9b4e110db8", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserWorkNumber" },
                values: new object[,]
                {
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), 0, "69260f3d-4cb3-4568-ae78-dfa62635f1db", null, false, "Столипен", "Тонев", false, null, null, "STOLIPEN.TONEV", "AQAAAAEAACcQAAAAEDVQKm59ysclCeXfX8Q02pPlyIk4/kIr2VrjxBS88rQvl8Z0OQvRj4pKgzFRu+747g==", null, false, "20caea7e-6e3e-4edd-8e52-93b6f6f6ee03", false, "Stolipen.Tonev", 38744 },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), 0, "4c982959-7b38-428c-aff5-327aa1d2a920", null, false, "Жерар", "Славчев", false, null, null, "GERAR.SLAVTCHEV", "AQAAAAEAACcQAAAAEGHR18xp0x10g9NMRLCy/QdAf5OJZLzdbRG8r04hOjcXrvg/+Tiohcg8Wy2DSYRfMQ==", null, false, "5400f2d3-6c25-45a1-8b96-3bae816a67ad", false, "Gerar.Slavtchev", 45571 },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), 0, "61fa90a2-27ef-4626-9f23-adf4f8c36deb", null, false, "Лазо", "Шишманов", false, null, null, "LAZO.CHICHMANOV", "AQAAAAEAACcQAAAAEI5QTLAaJ/9eKp0/yiS9htvLel6kNXD/Cb5DABjpduGHpE17eCQ2ofN9Ie9GSo23+Q==", null, false, "4560e7ac-143d-41fa-ad24-2f88c0dfc0fc", false, "Lazo.Chichmanov", 68340 },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), 0, "722d17c8-642d-431c-9446-afc7a7689f72", null, false, "Дан", "Игнатов", false, null, null, "IGNATOV.DAN", "AQAAAAEAACcQAAAAEDE9OV3lILJyhor75VuPFrkPyxEOzXazTMFMqReyZF/TfDtUXOUSgWZhuHUFy1eZ1g==", null, false, "1aad91f0-74ad-4d23-afe1-273157fc01cb", false, "Ignatov.Dan", 88327 },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), 0, "f12db1a3-766c-4abf-abc7-13efc370fbfc", null, false, "Флоро", "Станов", false, null, null, "FLORO.STANOV", "AQAAAAEAACcQAAAAEN08bE/S+rck/+pTCmI0HWz9MxOG/0XvciNxR32GaDZjhIzRy5VQ2sNA70dSQSDbvQ==", null, false, "09b19293-9d71-4828-a2ec-64b0d6f8574e", false, "Floro.Stanov", 71417 },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), 0, "88720165-d8cc-4245-9199-eb6bde99cded", null, false, "Руси", "Магичов", false, null, null, "RUSI.MAGITCHOV", "AQAAAAEAACcQAAAAEHl8cJc0SMD+ws1dLk5RKMK5V+QmNZqHaXZeQn08+X2gIitQqJuq+8BnEuvaC37f0w==", null, false, "da281ec0-adeb-48c1-8c0d-3921f4ae83ce", false, "Rusi.Magitchov", 44454 },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), 0, "e7f0ec79-ca66-4f80-9020-95e71ddd9b0f", null, false, "Дарен", "Павков", false, null, null, "DAREN.PAVKOV", "AQAAAAEAACcQAAAAEPPt9bbxzHN3uoztjQIDveTqFVXF9SToSRml2xhUmvSCIkx+UfFX5DRH3zuETK9wtw==", null, false, "b5a89333-5701-4f0b-9f13-57d97bd0e94c", false, "Daren.Pavkov", 98129 },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), 0, "fbc2cd55-cd0c-4da4-87aa-b122606b1609", null, false, "Данимил", "Тинков", false, null, null, "DANIMIL.TINKOV", "AQAAAAEAACcQAAAAEORC6EWx0weNveGuvDI9eaW/q2YAhBL/tqL1ywk9jS7qYkxhuDo9d5e76l4e4H4RuA==", null, false, "e07580be-84ef-4efd-8200-af5feedb2a76", false, "Danimil.Tinkov", 70677 },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), 0, "ad4abd70-c094-47c4-afae-3cad6dbdd8ec", null, false, "Сергей", "Попов", false, null, null, "POPOV.SERGEY", "AQAAAAEAACcQAAAAEJ5TndkKL4anOvxNsQh9AxLK7r/eM1QTcIT35eXhzaR61I7aOlLdqiG2b/oHwO7Slw==", null, false, "aee39010-b297-493f-84e2-3aa8c6ce3d40", false, "Popov.Sergey", 38011 },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), 0, "c5913205-bf8a-43a3-b00d-11b08b2ba3f1", null, false, "Пейо", "Ленков", false, null, null, "PEYO.LENKOV", "AQAAAAEAACcQAAAAEMNETwaconlI8gcPI16CEnic63ONESfVXMwCBUEOwBKZgAySaX37gZ3RaRDmzEQVxg==", null, false, "8dce7317-21c6-4e45-847a-6d9fdf5480d2", false, "Peyo.Lenkov", 62230 },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), 0, "fcc1e802-1afb-41b9-af7e-16bca5c7775c", null, false, "Аню", "Панчев", false, null, null, "ANUY.PANTCHEV", "AQAAAAEAACcQAAAAEGO1SrngZwQNPaD/STvI11EPSor1TZS5pQoxaXjuEikKKs28sPlp1AaT0XPLfBMpwQ==", null, false, "67a8c93c-2f75-4ddd-94bb-6fd674d6fe8c", false, "Anuy.Pantchev", 65072 },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), 0, "44606d9b-4765-4cc2-8f3d-53291694d175", null, false, "Друмчо", "Светозаров", false, null, null, "DRUMTCHO.SVETOZAROV", "AQAAAAEAACcQAAAAEET4hEQUlKznIlzd+cKQWFVKyauOd9ylqNrvGpNjIHfy+A5pnUrmlFTsaDbCCw8WFg==", null, false, "581a04e7-c75f-4ca7-b735-0ac83631c780", false, "Drumtcho.Svetozarov", 35236 },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), 0, "8d3158a0-c887-4724-8d7e-423ed1d304b1", null, false, "Дориян", "Славейков", false, null, null, "DORIYAN.SLAVEYKOV", "AQAAAAEAACcQAAAAENkdt3yGGEmr8jiXso76/Bvi6TUTDfRsmL+weUiIdD/KP0ucTZfDSXwHooyIQBsYNQ==", null, false, "b9f38c7f-81f1-44a2-9a3a-e4ac4ea0e1b3", false, "Doriyan.Slaveykov", 39676 },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), 0, "03348ca9-418d-44ff-9ae3-697132793687", null, false, "Менко", "Мирков", false, null, null, "MENKO.MIRKOV", "AQAAAAEAACcQAAAAEPScDTm0/itnUrHIrTQPFeLluwf7RHDgV3rTjEMo9atokdcN95cgpiOJil+IO7XUfg==", null, false, "352f3b01-4677-4d0b-849b-b8b046d2880c", false, "Menko.Mirkov", 19386 },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), 0, "37b74edd-8e2a-4413-80cb-7c2f8a7db380", null, false, "Силвиян", "Янов", false, null, null, "SILVIYAN.YANKOV", "AQAAAAEAACcQAAAAEMJncVE0uwLm+7jTlq5XQEY7ruJCvKRyw0kifjR9+qqdrLAQy5zWPXlokq6JzGPZ5g==", null, false, "515d1559-fec5-4eb6-a7f2-72719382d41a", false, "Silviyan.Yankov", 52291 },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), 0, "27ac00c0-1371-4432-8c01-7c118f3ee9d0", null, false, "Драгни", "Тодоров", false, null, null, "DRAGNI.TODOROV", "AQAAAAEAACcQAAAAEMIR3YMlCxei0Jxc8LoASg+qGN6dIf8HheFQFYw7PxPjuiVRDujwxmdkFh0fX+OYGA==", null, false, "37e96ad0-ed7c-4b27-81d6-a065b87484e4", false, "Dragni.Todorov", 80738 },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), 0, "527c5636-62e5-44e0-9794-8cbb7eda9215", null, false, "Доко", "Цанимиров", false, null, null, "DOKO.TSANIMIROV", "AQAAAAEAACcQAAAAEKo8PnSo0VDThKIBBUflZeNp12bVcHyNPnVbasH1BKC7YmrPGEsYw+WLu9yI2011XQ==", null, false, "15fc534a-f9b5-4b11-b12b-6f6955182515", false, "Doko.Tsanimirov", 46929 },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), 0, "62706599-bb62-4789-9489-10d3d68ca823", null, false, "Биню", "Тошков", false, null, null, "BINUY.TOCHKOV", "AQAAAAEAACcQAAAAEM+mveKp/wQlB8/DwlnL6eJ8U7SwnSUfLPe6byhxrNa3CWKdTe4Qmjuz6BB03I+RbQ==", null, false, "e69612a4-ec75-42ce-89f6-d27eb6f95006", false, "Binuy.Tochkov", 61815 },
                    { new Guid("f91c5b35-506c-4987-a89a-fba703b53f03"), 0, "9cf728bd-ad6d-4893-9090-b09df170359f", null, false, "Захари", "Тодеев", false, null, null, "ZAHARI.TODEEV", "AQAAAAEAACcQAAAAEMVoc+8SUHKWM7CxgIdyfjpFRhKNOeJm9D5Nsz1gaEw1D2TUGL2DZ/8KDgpbuwkS2g==", null, false, "58fe52c5-a71d-480c-8b65-45e95ffec7e6", false, "Zahari.Todeev", 50975 }
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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512") },
                    { new Guid("8a08f81e-e7db-44e8-b639-653d22648577"), new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3") },
                    { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89") },
                    { new Guid("8a08f81e-e7db-44e8-b639-653d22648577"), new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc") },
                    { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14") },
                    { new Guid("8a08f81e-e7db-44e8-b639-653d22648577"), new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274") },
                    { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a") },
                    { new Guid("8a08f81e-e7db-44e8-b639-653d22648577"), new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169") },
                    { new Guid("8a08f81e-e7db-44e8-b639-653d22648577"), new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb") },
                    { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("822edebf-23a5-4373-b56d-94078d984192") },
                    { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de") },
                    { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2") },
                    { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1") },
                    { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea") },
                    { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab") },
                    { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a") },
                    { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7") },
                    { new Guid("8a08f81e-e7db-44e8-b639-653d22648577"), new Guid("ecd856e4-96da-4296-a482-6f66680f1380") },
                    { new Guid("b6d9e0b1-7844-40dd-bd53-cee6cf8f3b62"), new Guid("f91c5b35-506c-4987-a89a-fba703b53f03") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
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
                    { new Guid("7e9d0982-c5fa-493d-b8b1-30babddbdfcc"), new Guid("d90ccba2-389c-4a1a-ac97-5c54340dadd4"), "Регенерация на хексан", "РХ" },
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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("237cb180-758f-465b-8d7d-bff014cf77b8"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8a08f81e-e7db-44e8-b639-653d22648577"), new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8a08f81e-e7db-44e8-b639-653d22648577"), new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8a08f81e-e7db-44e8-b639-653d22648577"), new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8a08f81e-e7db-44e8-b639-653d22648577"), new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8a08f81e-e7db-44e8-b639-653d22648577"), new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("822edebf-23a5-4373-b56d-94078d984192") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("26d978a0-e222-4209-a204-f632f093e657"), new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8a08f81e-e7db-44e8-b639-653d22648577"), new Guid("ecd856e4-96da-4296-a482-6f66680f1380") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b6d9e0b1-7844-40dd-bd53-cee6cf8f3b62"), new Guid("f91c5b35-506c-4987-a89a-fba703b53f03") });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("26d978a0-e222-4209-a204-f632f093e657"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8a08f81e-e7db-44e8-b639-653d22648577"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b6d9e0b1-7844-40dd-bd53-cee6cf8f3b62"));

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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f91c5b35-506c-4987-a89a-fba703b53f03"));

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
