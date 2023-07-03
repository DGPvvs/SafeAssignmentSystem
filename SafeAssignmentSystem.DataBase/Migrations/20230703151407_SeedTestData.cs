using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafeAssignmentSystem.DataBase.Migrations
{
    public partial class SeedTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "AspNetRoles",
                comment: "Модел на ролите");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("237cb180-758f-465b-8d7d-bff014cf77b8"), "a443f165-af94-4649-a266-2c4ab798e771", "NoRole", "NOROLE" },
                    { new Guid("26d978a0-e222-4209-a204-f632f093e657"), "19c03079-b267-497b-a813-8598347b4b77", "Operator", "OPERATOR" },
                    { new Guid("8a08f81e-e7db-44e8-b639-653d22648577"), "cecee6b6-a6b5-4da9-821b-2dfeb797771a", "Electrician", "ELECTRICIAN" },
                    { new Guid("b6d9e0b1-7844-40dd-bd53-cee6cf8f3b62"), "f9ac61b3-0e57-47eb-8685-c61c11078099", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserWorkNumber" },
                values: new object[,]
                {
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), 0, "1e7e23a9-5189-4fdc-a013-6b436fdd8eb4", null, false, "Столипен", "Тонев", false, null, null, "STOLIPEN.TONEV", "AQAAAAEAACcQAAAAEOBpEcbDZRcUKTQMv2jsUELLrslLt3VikqCoh/AYoqM58qP3/A8r36TVsiJRw2f0Rg==", null, false, "6cf39b8c-0063-42ea-bd15-505a3ecde8d7", false, "Stolipen.Tonev", 38744 },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), 0, "232ab070-a171-46bd-882e-ce198be02722", null, false, "Жерар", "Славчев", false, null, null, "GERAR.SLAVTCHEV", "AQAAAAEAACcQAAAAEGi/Y06WmAZcP0WLvGDYFzHvn7MNMzGLkmH7MjTesEteN+kDpMm08bMofoQIQL/SWQ==", null, false, "d973f406-fbfd-4248-a38c-6922e5921cde", false, "Gerar.Slavtchev", 45571 },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), 0, "7a9c8114-65f4-42ad-aa7e-bc192458680b", null, false, "Лазо", "Шишманов", false, null, null, "LAZO.CHICHMANOV", "AQAAAAEAACcQAAAAENEVvLnMfOwAcNt9xOymIMZKkwk6zcoCZJ9pr1ptsjiZ19srnQSHbSiDnJFbDA+7zw==", null, false, "264fcedb-85d0-4305-b273-ffb539c16f69", false, "Lazo.Chichmanov", 68340 },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), 0, "165f1a69-d30c-43d3-b026-0bdbce52d4b5", null, false, "Дан", "Игнатов", false, null, null, "IGNATOV.DAN", "AQAAAAEAACcQAAAAEJfBM4On35bADhWv0IKrSi7j1N0mESq2978Hn236KELYtAOzDyKqvlP7fnSpPyO5vg==", null, false, "05174ab8-b17e-43e3-9c3b-658daf094527", false, "Ignatov.Dan", 88327 },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), 0, "4f286326-05cd-4096-bf6e-79cdd7e087a9", null, false, "Флоро", "Станов", false, null, null, "FLORO.STANOV", "AQAAAAEAACcQAAAAEKxAPl/JIzgb46lBkGmhRFt3nD+ktRNPB/tAo5yMyv8/XwyEChU2p0+oGiyGkerqCA==", null, false, "f894879c-5826-43bb-b8cc-01364535b5c6", false, "Floro.Stanov", 71417 },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), 0, "b1a52c41-7aef-4a02-b3fd-a5e8efac2c45", null, false, "Руси", "Магичов", false, null, null, "RUSI.MAGITCHOV", "AQAAAAEAACcQAAAAEAT4LvFGCy91fMXv7NdDucYvumoRaw5Cmp90qBtSUgVBjQlZxdL/MKTksGpMWNYhUg==", null, false, "9ce60387-c55e-455c-8bde-9b2a9b97ba1e", false, "Rusi.Magitchov", 44454 },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), 0, "67be0e3c-a162-4317-acc4-4c1a3b7b1dae", null, false, "Дарен", "Павков", false, null, null, "DAREN.PAVKOV", "AQAAAAEAACcQAAAAEI2/G17AThlsWFNja4yDTQLNs7h59D0ItjlHB7hH49BXNw8EPAUfwvzi1yEvuABA3w==", null, false, "62ca47c0-c5d0-4d74-95b7-d2bdb5127cc9", false, "Daren.Pavkov", 98129 },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), 0, "283f4048-3439-4bab-a2ea-74ec5200e022", null, false, "Данимил", "Тинков", false, null, null, "DANIMIL.TINKOV", "AQAAAAEAACcQAAAAEPvojf8z8P6tLy0wiHCfwq2DGwM6tUuQ+ee6H7v6iA6C3dzdhe+KfXv+EGCXZEQz/w==", null, false, "c02c1ddd-4fe6-4cc4-af6f-17cdeb59cfcb", false, "Danimil.Tinkov", 70677 },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), 0, "2d5a8f1c-c5ed-4844-af3a-67b67f93519f", null, false, "Сергей", "Попов", false, null, null, "POPOV.SERGEY", "AQAAAAEAACcQAAAAEF00ULYyNeXiE87KjAtbza+QsE9U8KFtGFlth6jrcOHmaLtr0FW2SIFt0s8Oy4Hdzw==", null, false, "ac1e967f-5695-4a42-bc6a-d44041623267", false, "Popov.Sergey", 38011 },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), 0, "c6c8eaa8-7b9d-4da8-a7c7-1e08c98ea7ac", null, false, "Пейо", "Ленков", false, null, null, "PEYO.LENKOV", "AQAAAAEAACcQAAAAEOvTf3ItU86XGlvHto2L4wWfA1AzeR4w0nk7RcjWyyOYkIrKpzTJV8ishNcRmWohSA==", null, false, "3e589a61-42ae-433e-b5db-ce282c549b4d", false, "Peyo.Lenkov", 62230 },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), 0, "919bc178-d9f5-4aa9-b473-a735cf81a632", null, false, "Аню", "Панчев", false, null, null, "ANUY.PANTCHEV", "AQAAAAEAACcQAAAAEOzXu8J4rJT5i0CpJfcdoGbY9de+prAXKvn0dgTBM6Q4s+zNf9+DUFPdjJHqZLUHQg==", null, false, "ec067aa7-0a31-46e5-8f78-5e5785ff6aa6", false, "Anuy.Pantchev", 65072 },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), 0, "6df68553-465c-4a87-8615-7efd69cbd281", null, false, "Друмчо", "Светозаров", false, null, null, "DRUMTCHO.SVETOZAROV", "AQAAAAEAACcQAAAAEGb2ctAnN4S9uEsRVCvj2bQAMuyvJvewHmr9J9LeuVCnkJsbxWvEqnxwF/2VcE6LQw==", null, false, "31b4912a-b29f-4289-83e0-9e675707cc53", false, "Drumtcho.Svetozarov", 35236 },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), 0, "1eeaccf4-b671-4f5e-a901-6b49742ffe65", null, false, "Дориян", "Славейков", false, null, null, "DORIYAN.SLAVEYKOV", "AQAAAAEAACcQAAAAEFZVDZFj7NX3Bfift3potVXd7X8gpfkOqYpL/vWs4waeNsjWxzZl0XXf8R6pQbOiaA==", null, false, "03c20798-3cdd-4a5a-8e36-243f5c117948", false, "Doriyan.Slaveykov", 39676 },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), 0, "fcaebb44-3ac5-4378-8f32-10f70125ae7e", null, false, "Менко", "Мирков", false, null, null, "MENKO.MIRKOV", "AQAAAAEAACcQAAAAEIDD9XdprNmARY3u05zG3bD5bvrWX3UnfTh7Q4wILXimmBs74jQuZVxvZ17ErgVTSw==", null, false, "9c0acecc-3ded-4e6a-b355-47cf032b45eb", false, "Menko.Mirkov", 19386 },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), 0, "93a64ccb-defe-4f74-8840-c55dc7b128c0", null, false, "Силвиян", "Янов", false, null, null, "SILVIYAN.YANKOV", "AQAAAAEAACcQAAAAENImG0MlYBdKdXCaz7R8BmmwQjN0Xo20eVnuxdkNdGOtXEdKpk69CEB2TsPiPXFb5Q==", null, false, "049531cc-db4a-44fe-93ee-5053344a123b", false, "Silviyan.Yankov", 52291 },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), 0, "50b1c224-b955-47eb-a4e8-0c0592b2ba06", null, false, "Драгни", "Тодоров", false, null, null, "DRAGNI.TODOROV", "AQAAAAEAACcQAAAAEPZbIYsCsn3MZDIXRk8PX1yI1oGbJYXYHFRvFF5/NnEchYprJrqgA2ed0fwRmCpkdQ==", null, false, "30a7df18-eef9-46af-914e-5ca45b66ac17", false, "Dragni.Todorov", 80738 },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), 0, "5205952a-055c-4f8e-b5ee-356d1d668ed7", null, false, "Доко", "Цанимиров", false, null, null, "DOKO.TSANIMIROV", "AQAAAAEAACcQAAAAED4ukyb+skvIYMbrVyZzNDxiBWW7+VRsWhtQ0w1T5LJY4Al/mio7Azr1nr0LhaBW2Q==", null, false, "7fa21f88-5375-4cb6-be1d-f6dd4a15094b", false, "Doko.Tsanimirov", 46929 },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), 0, "a2ce0a77-0ea3-4b60-87dc-35150987851d", null, false, "Биню", "Тошков", false, null, null, "BINUY.TOCHKOV", "AQAAAAEAACcQAAAAEMpkknG6ArAENw85+aRqGDulVweHsN9q7y+PusNCP7NCridCNXDHUGFnz2+ETLOncw==", null, false, "1920eb27-d2a6-4a82-a24f-037218d1a154", false, "Binuy.Tochkov", 61815 },
                    { new Guid("f91c5b35-506c-4987-a89a-fba703b53f03"), 0, "536db7f8-1264-4290-9d26-03f0179032f1", null, false, "Захари", "Тодеев", false, null, null, "ZAHARI.TODEEV", "AQAAAAEAACcQAAAAEK4xsPOFc0LG7Gm7Tz6qh6VRzK4aKJvZMr1SFFtPUtHkDyq9l53sXO33ns5EW0y0ow==", null, false, "df5affc3-95c2-4e04-9d25-5680d8d18061", false, "Zahari.Todeev", 50975 }
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
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 3, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 3, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 3, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 3, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 3, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 3, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 3, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 3, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 3, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 4, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 4, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 4, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 4, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 4, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 4, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 4, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 4, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 4, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 5, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 5, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 5, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 5, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 5, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 5, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 5, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 5, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 5, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 6, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 6, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 6, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 6, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 6, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 6, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 6, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 6, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 6, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 7, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 7, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 7, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 7, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 7, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 7, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 7, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 7, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 7, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 9, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 9, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 9, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 9, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 9, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 9, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 9, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 9, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 9, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 10, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 10, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 10, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 10, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 10, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 10, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 10, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 10, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 10, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 11, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 11, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 11, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 11, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 11, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 11, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 11, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 11, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 11, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 12, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 12, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 12, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 12, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 12, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 12, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 12, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 12, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 12, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 13, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 13, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 13, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 13, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 13, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 13, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 13, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 13, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 13, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 14, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 14, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 14, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 14, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 14, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 14, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 14, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 14, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 14, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 15, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 15, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 15, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 15, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 15, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 15, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 15, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 15, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 15, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 16, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 16, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 16, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 16, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 16, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 16, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 16, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 16, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 16, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 17, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 17, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 17, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 17, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 17, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 17, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 17, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 17, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 17, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 18, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 18, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 18, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 18, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 18, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 18, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 18, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 18, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 18, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 19, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 19, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 19, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 19, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 19, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 19, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 19, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 19, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 19, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 20, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 20, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 20, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 20, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 20, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 20, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 20, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 20, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 20, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 21, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 21, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 21, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 21, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 21, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 21, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 21, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 21, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 21, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 22, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 22, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 22, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 22, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 22, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 22, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 22, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 22, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 22, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 23, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 23, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 23, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 23, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 23, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 23, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 23, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 23, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 23, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 24, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 24, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 24, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 24, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 24, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 24, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 24, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 24, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 24, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 25, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 25, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 25, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 25, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 25, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 25, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 25, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 25, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 25, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 26, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 26, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 26, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 26, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 26, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 26, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 26, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 26, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 26, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 27, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 27, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 27, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 27, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 27, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 27, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 27, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 27, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 27, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 28, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 28, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 28, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 28, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 28, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 28, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 28, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 28, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 28, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 29, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 29, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 29, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 29, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 29, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 29, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 29, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 29, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 29, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 30, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 30, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 30, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 30, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 30, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 30, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 30, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 30, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 30, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 31, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 31, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 31, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 31, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 31, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 31, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 31, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 31, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 31, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 1, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 1, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 1, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 1, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 1, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 1, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 1, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 1, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 1, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 2, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 2, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 2, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 2, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 2, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 2, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 2, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 2, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 2, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
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
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 3, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 3, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 3, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 3, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 3, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 3, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 3, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 3, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 3, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 4, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 4, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 4, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 4, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 4, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 4, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 4, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 4, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 4, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 5, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 5, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 5, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 5, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 5, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 5, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 5, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 5, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 5, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 6, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 6, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 6, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 6, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 6, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 6, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 6, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 6, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 6, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 7, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 7, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 7, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 7, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 7, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 7, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 7, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 7, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 7, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 8, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 9, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 9, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 9, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 9, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 9, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 9, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 9, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 9, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 9, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 10, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 10, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 10, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 10, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 10, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 10, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 10, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 10, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 10, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 11, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 11, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 11, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 11, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 11, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 11, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 11, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 11, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 11, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 12, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 12, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 12, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 12, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 12, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 12, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 12, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 12, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 12, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 13, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 13, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 13, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 13, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 13, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 13, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 13, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 13, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 13, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 14, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 14, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 14, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 14, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 14, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 14, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 14, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 14, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 14, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 15, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 15, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 15, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 15, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 15, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 15, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 15, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 15, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 15, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 16, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 16, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 16, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 16, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 16, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 16, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 16, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 16, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 16, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 17, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 17, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 17, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 17, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 17, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 17, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 17, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 17, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 17, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 18, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 18, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 18, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 18, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 18, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 18, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 18, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 18, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 18, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 19, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 19, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 19, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 19, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 19, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 19, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 19, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 19, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 19, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 20, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 20, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 20, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 20, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 20, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 20, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 20, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 20, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 20, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 21, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 21, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 21, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 21, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 21, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 21, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 21, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 21, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 21, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 22, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 22, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 22, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 22, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 22, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 22, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 22, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 22, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 22, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 23, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 23, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 23, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 23, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 23, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 23, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 23, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 23, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 23, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 24, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 24, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 24, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 24, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 24, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 24, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 24, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 24, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 24, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 25, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 25, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 25, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 25, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 25, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 25, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 25, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 25, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 25, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 26, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 26, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 26, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 26, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 26, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 26, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 26, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 26, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 26, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 27, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 27, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 27, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 27, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 27, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 27, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 27, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 27, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 27, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 28, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 28, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 28, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 28, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 28, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 28, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 28, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 28, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 28, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 29, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 29, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 29, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 29, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 29, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 29, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 29, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 29, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 29, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 30, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 30, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 30, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 30, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 30, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 30, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 30, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 30, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 30, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 31, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 31, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 31, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 31, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 31, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 31, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 31, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 31, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 31, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 1, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 1, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 1, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 1, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 1, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 1, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 1, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 1, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 1, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 2, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 2, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 2, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 2, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 2, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 2, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 2, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 2, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 2, 18, 14, 6, 949, DateTimeKind.Local).AddTicks(7711) });

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

            migrationBuilder.AlterTable(
                name: "AspNetRoles",
                oldComment: "Модел на ролите");
        }
    }
}
