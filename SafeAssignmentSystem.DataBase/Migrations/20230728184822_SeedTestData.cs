using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafeAssignmentSystem.DataBase.Migrations
{
    public partial class SeedTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "SafeAssignmentDocuments",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                comment: "Номер на наряд според вътрешнонарядната номерация",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "Номер на наряд според вътрешнонарядната номерация");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("237cb180-758f-465b-8d7d-bff014cf77b8"), "1fe0d320-777b-40b5-9f93-3d82584308a6", "NoRole", "NOROLE" },
                    { new Guid("26d978a0-e222-4209-a204-f632f093e657"), "bbfa1c87-432a-4586-97f2-e0c0e6f9e0ff", "Operator", "OPERATOR" },
                    { new Guid("8a08f81e-e7db-44e8-b639-653d22648577"), "7a19f23f-20b0-4ddc-94af-dc6c76e047a5", "Electrician", "ELECTRICIAN" },
                    { new Guid("b6d9e0b1-7844-40dd-bd53-cee6cf8f3b62"), "b895f358-fb7c-4484-b702-d4081dcef0fe", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserWorkNumber" },
                values: new object[,]
                {
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), 0, "183e9e6e-c900-411e-bc43-b5f458a3dbb4", null, false, "Столипен", "Тонев", false, null, null, "STOLIPEN.TONEV", "AQAAAAEAACcQAAAAEG9zNdtqAnp8WKxlf3tJ7LXC5n/b3tBH/RLXQBnPEy0C3bNl5y65ELYjmVX4S50+Eg==", null, false, "9aceefbe-a50c-4494-8cec-2231012cde27", false, "Stolipen.Tonev", 38744 },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), 0, "4d9cb773-25ac-42f2-ab57-d4415f2a13cc", null, false, "Жерар", "Славчев", false, null, null, "GERAR.SLAVTCHEV", "AQAAAAEAACcQAAAAEKrksNRQ9LDMZq0O+GT2Jjya0J0SS8RZBXZdh1fsvrgcBdbCQJY42a3uqnOtPoxeMw==", null, false, "e0b7b360-3fd7-47b9-ab71-32f38f1e6a46", false, "Gerar.Slavtchev", 45571 },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), 0, "fb7effc9-ab29-4d3f-a86c-dbbfc6546215", null, false, "Лазо", "Шишманов", false, null, null, "LAZO.CHICHMANOV", "AQAAAAEAACcQAAAAEIHQA2ef6+Nllh46C8IPMHvCGaObNTnsHQ2jV4qdV+y2ubOdWvfqjJdlYNhuxSQ1bw==", null, false, "da95fc17-d527-4d4e-9508-f1fd5a7242ec", false, "Lazo.Chichmanov", 68340 },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), 0, "52487577-42c9-46e3-9b4f-66412cbd1a5f", null, false, "Дан", "Игнатов", false, null, null, "IGNATOV.DAN", "AQAAAAEAACcQAAAAEP+mzf/qAViP0WT4b3OQp6UaQMjIoaNj6ma3QvsreDjqgI47FwqkguZ+985F7nSATw==", null, false, "cf92c309-882d-49f2-9af4-18a05adde5be", false, "Ignatov.Dan", 88327 },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), 0, "2118c73c-fdf6-4841-a898-a28435f5eaaf", null, false, "Флоро", "Станов", false, null, null, "FLORO.STANOV", "AQAAAAEAACcQAAAAEGHzl4n+e3GYpDJ4k+b/++4RbpPzHeluh+R7DJ8PmkHdpXODkPbKsiYQwIWGHX++KA==", null, false, "c2825720-d68d-488a-a855-7605b787a1d3", false, "Floro.Stanov", 71417 },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), 0, "eb4a21fe-8929-4760-bea5-1bd22df8eabe", null, false, "Руси", "Магичов", false, null, null, "RUSI.MAGITCHOV", "AQAAAAEAACcQAAAAEM9v61v/FELeZTRrhVRNupdOsd7zofYXEnUAPJ9I42hG/gVSc36nyc5pKkcMj3f3Dg==", null, false, "6ae25c5b-26a6-4da0-b732-e242ff435ffb", false, "Rusi.Magitchov", 44454 },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), 0, "55149d37-8ba8-4a69-876c-daa7eb651e5b", null, false, "Дарен", "Павков", false, null, null, "DAREN.PAVKOV", "AQAAAAEAACcQAAAAEOrlTy9R2fc5pIsTCiWGcDCUXM0sBT8XSIDL53w8/VchmeICIZ0UEs0U37IHEuTBWQ==", null, false, "20355fe6-c68e-4cf9-be92-6e75dd3e3861", false, "Daren.Pavkov", 98129 },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), 0, "f08e7453-10fa-4f58-a47d-58d9e70ed6fb", null, false, "Данимил", "Тинков", false, null, null, "DANIMIL.TINKOV", "AQAAAAEAACcQAAAAEKDeBE8qdHhfruhWVtqRzyLC5qE8O3vOG6KgcUUylGqrJuoOThUvqeMRgC/LSzzeyg==", null, false, "963bd4c2-e7df-45fd-a3c3-5ead68d27fbf", false, "Danimil.Tinkov", 70677 },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), 0, "920ec165-e267-4d2e-99d4-2ced0ad746de", null, false, "Сергей", "Попов", false, null, null, "POPOV.SERGEY", "AQAAAAEAACcQAAAAEG9w1QznpvQo4pwGZsa9X7rgaw08vntBWA4CyhfVZVabvKERWejKwzhk8kJlwa+L4Q==", null, false, "a6c02f01-e2f3-4f35-b59b-2a8110e472c5", false, "Popov.Sergey", 38011 },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), 0, "b9e8fe2c-9222-4a8b-a450-e52bfa9ed259", null, false, "Пейо", "Ленков", false, null, null, "PEYO.LENKOV", "AQAAAAEAACcQAAAAEIwhvHcp/iycQrXIGqwt3at1QgPcGxLPKBbCq8+428D4a32+A7wOQjq8Tj8B6UODIg==", null, false, "49c8d361-27ad-4676-8da0-66fa66d9747a", false, "Peyo.Lenkov", 62230 },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), 0, "9b125342-d7e5-475f-b44b-7babae3607b4", null, false, "Аню", "Панчев", false, null, null, "ANUY.PANTCHEV", "AQAAAAEAACcQAAAAEKF6Ujawbc0nj+LoyUb7SQGjYgUwRpXnYfkszrq/SCwDfhnVkI0/0j5+z4Eq3kwZWA==", null, false, "75ce72b0-c457-44a2-b579-5f8fecab5754", false, "Anuy.Pantchev", 65072 },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), 0, "b3fa71b1-0d0b-4346-a521-2e2e91354f73", null, false, "Друмчо", "Светозаров", false, null, null, "DRUMTCHO.SVETOZAROV", "AQAAAAEAACcQAAAAEBAPVtkzFBV2/vfLlpiCSQmyXD+szGKZBDxyu1EM8Us4m18e68yJab6oBLAw+Dnaog==", null, false, "c5f16969-d1e8-44ba-b543-bcaf15484a59", false, "Drumtcho.Svetozarov", 35236 },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), 0, "14a74491-ce7d-47a9-b90a-4ba1bf7e698c", null, false, "Дориян", "Славейков", false, null, null, "DORIYAN.SLAVEYKOV", "AQAAAAEAACcQAAAAEGMQWqdcVvHKPI9sSPR9eZ5WonK0crcgl7WqQrCE/zJpzMtCYfyi1l+x6QUq5uyDlQ==", null, false, "8ca4d178-35fc-4de1-a06d-4701318d91d4", false, "Doriyan.Slaveykov", 39676 },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), 0, "1be2477f-6e86-45aa-9ce6-8c5cce0a131c", null, false, "Менко", "Мирков", false, null, null, "MENKO.MIRKOV", "AQAAAAEAACcQAAAAEAE2vIl/YaPPCEYyWSrWq2XHssCEi1U/zmAZpOIX8nIgmS3g/8MyuJ9nSJ7I0AUkYw==", null, false, "0d8583db-d7c6-49b1-9c6b-1e0fcdbae58f", false, "Menko.Mirkov", 19386 },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), 0, "0ef890c0-53ee-4c20-8ae0-192edf9dfe88", null, false, "Силвиян", "Янов", false, null, null, "SILVIYAN.YANKOV", "AQAAAAEAACcQAAAAEF56gwEQdP4KxbXnxIjMu4Zgjk7NtOMLe+eFw3ov6ttiW2YXv/YGhfHRn28gfGhBdQ==", null, false, "917afaa0-7e5f-41e6-95a1-3292c4ebbe30", false, "Silviyan.Yankov", 52291 },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), 0, "16d28bdd-e35a-4eeb-94aa-c3bb622b603e", null, false, "Драгни", "Тодоров", false, null, null, "DRAGNI.TODOROV", "AQAAAAEAACcQAAAAEH8j1eBk3Fl8pRrQIqPBX1KiwpqKFgocuK+5f7ht7/KK0KJyvw24B2bnP22ox0wqLA==", null, false, "1ff4669a-0455-4ad9-93af-38b618faaaeb", false, "Dragni.Todorov", 80738 },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), 0, "3da8a910-f877-4ec8-8c96-de3993f348b4", null, false, "Доко", "Цанимиров", false, null, null, "DOKO.TSANIMIROV", "AQAAAAEAACcQAAAAEFu+p3h1A8ze9JhEYhk/SZHQTpacPWwbYl4rM7W1FjaWYFCoPob9jI53KSnpGBJcjQ==", null, false, "89209cdf-9b53-4df7-817e-9e5514f5310d", false, "Doko.Tsanimirov", 46929 },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), 0, "4c5081bd-1dda-4282-9fe8-517cbac8da50", null, false, "Биню", "Тошков", false, null, null, "BINUY.TOCHKOV", "AQAAAAEAACcQAAAAEKfYe1F1kg5E7gCgaVWxViLagDqudtQunx4KAbxpEfanu9kdkwf4WYB5HhkPmzzPQw==", null, false, "933b9fb4-cd7a-4098-9939-7a79b40271bf", false, "Binuy.Tochkov", 61815 },
                    { new Guid("f91c5b35-506c-4987-a89a-fba703b53f03"), 0, "1c7f5327-e147-4ed8-87ef-187fb748e821", null, false, "Захари", "Тодеев", false, null, null, "ZAHARI.TODEEV", "AQAAAAEAACcQAAAAEPMjnc1f/vqV7BiaS+MR5kvywlEdqFeXEQw/vyyBwEqYD7DILShLQquT/kg5wOB8wA==", null, false, "ed394960-8d31-4cc4-ad44-0db2a291f758", false, "Zahari.Todeev", 50975 }
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
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "PlantInstalations",
                columns: new[] { "Id", "ComplexId", "FullName", "Name" },
                values: new object[,]
                {
                    { new Guid("0c3d7329-a0af-45ee-8ba2-4ac6b0320e3e"), new Guid("d90ccba2-389c-4a1a-ac97-5c54340dadd4"), "Хидрокрекинг на гудрон", "ХККр" },
                    { new Guid("0d5fc355-ba0d-494e-aa2d-421616e9f651"), new Guid("79afcb01-d8f3-4fe0-9fa2-fd95b72c615f"), "МТБЕ и Хидроочистка-1 и 3", "МТБЕ и ХО 1, 3" },
                    { new Guid("13d901bf-8203-4280-ae70-24eef3fed196"), new Guid("d90ccba2-389c-4a1a-ac97-5c54340dadd4"), "Газова сяра", "ГС" },
                    { new Guid("1b3e962a-ab8f-4fec-87d3-3221edb3bad0"), new Guid("d90ccba2-389c-4a1a-ac97-5c54340dadd4"), "Производство на битуми и резервоарен парк за тъмни горива", "БИ" },
                    { new Guid("27e67a5e-9def-417e-b479-a3374ac01357"), new Guid("d90ccba2-389c-4a1a-ac97-5c54340dadd4"), "Сярно-кисело алкилиране и абсорбционно газофракциониране", "СКА" },
                    { new Guid("35dbc6f8-e63e-46a5-98ec-305161eca10f"), new Guid("79afcb01-d8f3-4fe0-9fa2-fd95b72c615f"), "Хидрообезсерване на бензин-1 и Хидроочистка-2", "ХО 2" },
                    { new Guid("38a9c7f5-45b6-4783-a1ba-365f22cb8cea"), new Guid("bd922bb0-94af-4bf0-9a99-2431661a27b6"), "Полимеризация на пропилен", "ПП" },
                    { new Guid("439d96e7-35fd-4037-a88e-ac56dd11e9d8"), new Guid("bd922bb0-94af-4bf0-9a99-2431661a27b6"), "Гранулация на полипропилен", "ГППр" },
                    { new Guid("4dabf64e-adb1-486a-b208-b07c5fabc440"), new Guid("d90ccba2-389c-4a1a-ac97-5c54340dadd4"), "Водородна инсталация", "ВИ" },
                    { new Guid("50465de6-39bd-4370-9e51-b7f60f56130a"), new Guid("79afcb01-d8f3-4fe0-9fa2-fd95b72c615f"), "Хидроочистка-5", "ХО 5" },
                    { new Guid("5078a11e-d2b0-40ca-ae46-79d81197af11"), new Guid("d90ccba2-389c-4a1a-ac97-5c54340dadd4"), "Регенерация на МДЕА и кисели води", "РМДЕА и РКВ" },
                    { new Guid("7e9d0982-c5fa-493d-b8b1-30babddbdfcc"), new Guid("d90ccba2-389c-4a1a-ac97-5c54340dadd4"), "Регенерация на хексан", "РХ" },
                    { new Guid("8b6563b0-5bc0-4778-bc4c-30fa347d9854"), new Guid("fe306aa1-f678-4e94-9d86-308ed58fd305"), "Втечнени газове, авто и жп. наливни естакади", "ВГ и АЖПН" },
                    { new Guid("973994a0-3ee2-4aba-b422-bc12be18040c"), new Guid("d90ccba2-389c-4a1a-ac97-5c54340dadd4"), "Каталитичен крекинг", "ККр" },
                    { new Guid("c05340da-e358-47f7-822e-bde8030f456a"), new Guid("79afcb01-d8f3-4fe0-9fa2-fd95b72c615f"), "Централно газофракциониране и хидрообезсерване", "ЦГФИ" },
                    { new Guid("c639c036-bdc1-4e54-9425-c77ab00658a3"), new Guid("125b8f04-7c38-4d1b-b39e-6d750e7bd037"), "Централна пречиствателна станция", "ЦПС" },
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
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

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
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

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
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Local) });

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

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "SafeAssignmentDocuments",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                comment: "Номер на наряд според вътрешнонарядната номерация",
                oldClrType: typeof(string),
                oldType: "nvarchar(55)",
                oldMaxLength: 55,
                oldComment: "Номер на наряд според вътрешнонарядната номерация");
        }
    }
}
