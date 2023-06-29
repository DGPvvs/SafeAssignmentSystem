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
                    { new Guid("26d978a0-e222-4209-a204-f632f093e657"), "8a96cd73-494b-4d8a-802e-09e0c99e9e75", "Operator", "OPERATOR" },
                    { new Guid("8a08f81e-e7db-44e8-b639-653d22648577"), "b58d90b9-dd0c-4087-a01b-eeed806053d0", "Electrician", "ELECTRICIAN" },
                    { new Guid("b6d9e0b1-7844-40dd-bd53-cee6cf8f3b62"), "3e6dc056-256e-4519-af55-4cc05bded1a2", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserWorkNumber" },
                values: new object[,]
                {
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), 0, "fe2606a5-e5f9-47df-85f4-726e78e3784a", null, false, "Столипен", "Тонев", false, null, null, "STOLIPEN.TONEV", "AQAAAAEAACcQAAAAECBWm29xQWaOCuHQIV3RaLf8ZJ+wDsR4MC0sxRP9Xa4pmo5zNEH+GbJm58RZ0Wgxgw==", null, false, "4f8f2551-ea28-4a1f-b8ab-f089300e93c9", false, "Stolipen.Tonev", 38744 },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), 0, "ce807a9a-f599-4cb7-9d62-bae07f69f508", null, false, "Жерар", "Славчев", false, null, null, "GERAR.SLAVTCHEV", "AQAAAAEAACcQAAAAELKZpUgsYVSKJDQUQ7uXlTOLDxGmcKNfRIn3JuXD6iaUOIGpCpw3/+GyxHwxl88ZCQ==", null, false, "81bf1621-b875-478b-a7b2-c1fae3a410b1", false, "Gerar.Slavtchev", 45571 },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), 0, "0ebf0748-51bb-4824-a26a-8d984e28188a", null, false, "Лазо", "Шишманов", false, null, null, "LAZO.CHICHMANOV", "AQAAAAEAACcQAAAAEEaUTMRzZ7MP8A4jdyK3vIOUwItJfqz984fxJDa1nT2D/lPbgiinnpuBu3hiuynOTg==", null, false, "4ddcc11a-034b-43bc-af47-35e4d596d0d3", false, "Lazo.Chichmanov", 68340 },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), 0, "c7a00dca-e9d3-4140-85b7-99706e4aa51c", null, false, "Дан", "Игнатов", false, null, null, "IGNATOV.DAN", "AQAAAAEAACcQAAAAEN6U9yvNhnsc7DT0JFL0yMtGeFZmZwE+xJTRzSuT3TcR06WOoebJEWB0Luc3dl9mIA==", null, false, "4114b56d-76ae-4dfd-9bc8-df9eb22ee003", false, "Ignatov.Dan", 88327 },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), 0, "5a00cfab-25de-4fd4-b9ae-af48799f0983", null, false, "Флоро", "Станов", false, null, null, "FLORO.STANOV", "AQAAAAEAACcQAAAAEFDS73lVwIsZNLvn/3F+fwf1VLW5p70NvkXczecvy4/326+e0/KxdHUjtLFghKCOiA==", null, false, "54c71839-11cf-4067-bbfe-f449b0473617", false, "Floro.Stanov", 71417 },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), 0, "657c7f25-4906-40c9-b896-26c862212590", null, false, "Руси", "Магичов", false, null, null, "RUSI.MAGITCHOV", "AQAAAAEAACcQAAAAEMuYqb4XWOgSjO5LmQrBIKpkw05OQYNpUY1+PjoaqFuou1ICH/7PtVjOvbRWmxkCOA==", null, false, "7b2438f1-6a46-466f-b756-84233247145a", false, "Rusi.Magitchov", 44454 },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), 0, "4c612df3-3b01-4fbf-845c-da7e70e8eedb", null, false, "Дарен", "Павков", false, null, null, "DAREN.PAVKOV", "AQAAAAEAACcQAAAAEJsnz+luquQKhMX8V8BLT13qy6EvYn4GDuO9S0NufM0QrKaf0HqUEQstoMo3x6R0Bg==", null, false, "51b220ae-a359-4308-bb9b-86fe0e7cf071", false, "Daren.Pavkov", 98129 },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), 0, "239bbeb9-b5d5-47d5-b82f-3b16277cf4ea", null, false, "Данимил", "Тинков", false, null, null, "DANIMIL.TINKOV", "AQAAAAEAACcQAAAAEF3xXDI3gLn7KoO2D+jLYstz13nxwR/33ilq/c77m8LW75kh0LvEX6PdM50IMPKfig==", null, false, "a0207d69-06f2-4019-8c17-70ea63555fdd", false, "Danimil.Tinkov", 70677 },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), 0, "c40dbcdd-80df-4f4a-b2ee-a1f99a26bf41", null, false, "Сергей", "Попов", false, null, null, "POPOV.SERGEY", "AQAAAAEAACcQAAAAEGUoT46NZjA8qY7BdztcZ5bxbYbpiE3uuHKLXykqDKoGVs+22+zF3mmsG3DEhb4s7g==", null, false, "d8b7ccb8-7c4e-4106-9775-90b1e0993a10", false, "Popov.Sergey", 38011 },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), 0, "180ffd97-1e99-4bba-a9a9-8b780c3ebe86", null, false, "Пейо", "Ленков", false, null, null, "PEYO.LENKOV", "AQAAAAEAACcQAAAAEOOAKUNeRcT46hYkrKuMHJ7TnmAS6zCY725UxVnQ6KDEVdyzpxl5chAJ3H3uFZxeIA==", null, false, "bc69bdcd-75aa-4dde-80e3-35b2417ad01e", false, "Peyo.Lenkov", 62230 },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), 0, "1101d396-f2fd-4457-9362-9d1cd7afdae9", null, false, "Аню", "Панчев", false, null, null, "ANUY.PANTCHEV", "AQAAAAEAACcQAAAAEIUEQIWbnpS3XyXLfjKdbVkrp77geltD0DHHcEw5dPJQVJyho1dxMoSRZd/qxkH4hQ==", null, false, "4aee7e2a-78f6-4de6-9035-ffda5954f3da", false, "Anuy.Pantchev", 65072 },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), 0, "2e9adf67-18e3-43b0-accc-00cdf06a6091", null, false, "Друмчо", "Светозаров", false, null, null, "DRUMTCHO.SVETOZAROV", "AQAAAAEAACcQAAAAEIt6wyfoQqSAqdOXaE6r+DfEVgiz8WjenmfWhuio6ZkX75DF2I9NLlXCEBS1U7iLgw==", null, false, "8cfb423c-dcb8-41af-80cd-fbaabd693366", false, "Drumtcho.Svetozarov", 35236 },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), 0, "9bd91a38-9d0b-4875-90a9-375855d54a2a", null, false, "Дориян", "Славейков", false, null, null, "DORIYAN.SLAVEYKOV", "AQAAAAEAACcQAAAAEAXr6Jn1hNktRaucjt7sWECNx0TAk0xFG6pOeCC+XbYGRgYVae0THtcCIrdfwVU9zg==", null, false, "18af7f13-dbe2-4bca-af2b-7d4b1b4ef60e", false, "Doriyan.Slaveykov", 39676 },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), 0, "654c5a0b-488e-4c7e-8d7b-2b36fc8e8bfd", null, false, "Менко", "Мирков", false, null, null, "MENKO.MIRKOV", "AQAAAAEAACcQAAAAEAIbTrxootiFG3rTgjrUgo8jPiifkpRcVuN4p9FHtGIY2DScYVfvfopu4fKUbmflGA==", null, false, "7273c2c5-a43d-4dbb-af84-590e21f350b1", false, "Menko.Mirkov", 19386 },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), 0, "0cf48fc5-6b58-42ea-8e59-735bff59d64b", null, false, "Силвиян", "Янов", false, null, null, "SILVIYAN.YANKOV", "AQAAAAEAACcQAAAAEPbq+4ECUj9v1w2hVEWFmLD2AIUs5FnsOlEQE4wg2lFdPCOOXxmjW/zPr7wYk8xRpA==", null, false, "a746cea9-07a0-46a0-a49a-ec6ea99cc72e", false, "Silviyan.Yankov", 52291 },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), 0, "fe046e62-08b5-453a-b756-ed3f9854c47f", null, false, "Драгни", "Тодоров", false, null, null, "DRAGNI.TODOROV", "AQAAAAEAACcQAAAAEB4pBKa7nAa9bNnJJ6G0fL0ADFjhi9xc/afGltABWqMX54JkN27i91mEM0geo/jvkg==", null, false, "6723b4b5-8321-4c63-8268-692e8101b910", false, "Dragni.Todorov", 80738 },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), 0, "4381a4fe-822a-442d-8918-e33af1077eee", null, false, "Доко", "Цанимиров", false, null, null, "DOKO.TSANIMIROV", "AQAAAAEAACcQAAAAECwJuvDXSX5941051pol4aZkAzYTiYzdvuOGv59d/3o4lkGN1T0B7Lv1nt5N+zZxWw==", null, false, "ad16833c-173b-4eaa-8418-974fa2a5f9f2", false, "Doko.Tsanimirov", 46929 },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), 0, "b3c7f017-17c0-481f-80ec-638ea46b1166", null, false, "Биню", "Тошков", false, null, null, "BINUY.TOCHKOV", "AQAAAAEAACcQAAAAEFBDrhRpbSvEkitgkf8Z1FJoSmLkMtXPixZfWKavi18xa6kZbK0jT00lO6oSacNA5A==", null, false, "5564d5a7-d0c6-43c7-990e-4d6c496e0fae", false, "Binuy.Tochkov", 61815 },
                    { new Guid("f91c5b35-506c-4987-a89a-fba703b53f03"), 0, "18c51309-30eb-48e6-852f-f72027aba97d", null, false, "Захари", "Тодеев", false, null, null, "ZAHARI.TODEEV", "AQAAAAEAACcQAAAAELO52htdCl1TXUAW96a92eYgJLVN7BUVLMAdEVdzymnM4Q3agNpMF6lUZQCkQq3BrQ==", null, false, "7ae10ae3-d203-479a-a811-08fb0e8691cd", false, "Zahari.Todeev", 50975 }
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
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 6, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 6, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 6, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 6, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 6, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 6, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 6, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 6, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 6, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 6, 30, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 6, 30, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 6, 30, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 6, 30, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 6, 30, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 6, 30, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 6, 30, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 6, 30, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 6, 30, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 1, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 1, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 1, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 1, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 1, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 1, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 1, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 1, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 1, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 2, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 2, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 2, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 2, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 2, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 2, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 2, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 2, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 2, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 3, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 3, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 3, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 3, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 3, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 3, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 3, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 3, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 3, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 5, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 5, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 5, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 5, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 5, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 5, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 5, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 5, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 5, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 6, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 6, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 6, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 6, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 6, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 6, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 6, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 6, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 6, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 7, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 7, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 7, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 7, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 7, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 7, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 7, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 7, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 7, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 8, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 8, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 8, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 8, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 8, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 8, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 8, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 8, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 8, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 9, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 9, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 9, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 9, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 9, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 9, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 9, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 9, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 9, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 10, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 10, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 10, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 10, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 10, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 10, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 10, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 10, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 10, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 11, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 11, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 11, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 11, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 11, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 11, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 11, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 11, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 11, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 12, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 12, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 12, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 12, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 12, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 12, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 12, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 12, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 12, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 13, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 13, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 13, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 13, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 13, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 13, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 13, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 13, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 13, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 14, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 14, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 14, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 14, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 14, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 14, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 14, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 14, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 14, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 15, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 15, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 15, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 15, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 15, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 15, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 15, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 15, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 15, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 16, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 16, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 16, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 16, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 16, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 16, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 16, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 16, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 16, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 17, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 17, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 17, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 17, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 17, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 17, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 17, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 17, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 17, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 18, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 18, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 18, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 18, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 18, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 18, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 18, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 18, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 18, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 19, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 19, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 19, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 19, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 19, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 19, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 19, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 19, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 19, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 20, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 20, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 20, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 20, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 20, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 20, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 20, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 20, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 20, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 21, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 21, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 21, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 21, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 21, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 21, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 21, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 21, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 21, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 22, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 22, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 22, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 22, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 22, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 22, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 22, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 22, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 22, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 23, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 23, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 23, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 23, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 23, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 23, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 23, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 23, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 23, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 24, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 24, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 24, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 24, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 24, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 24, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 24, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 24, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 24, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 25, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 25, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 25, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 25, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 25, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 25, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 25, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 25, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 25, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 26, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 26, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 26, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 26, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 26, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 26, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 26, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 26, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 26, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 27, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 27, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 27, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 27, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 27, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 27, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 27, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 27, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 27, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 28, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 28, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 28, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 28, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 28, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 28, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 28, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 28, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 28, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
                });

            migrationBuilder.InsertData(
                table: "ChangedsSchedules",
                columns: new[] { "ApplicationUserId", "Date", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") },
                    { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("51e3023b-5967-4221-ba1e-977fdff10eda") },
                    { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("8dd62cbc-0f4d-4868-bdaa-0bb3980fc47d") },
                    { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510), new Guid("ad095ab8-ed2b-4f15-9f2d-088188db4ee2") }
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
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 6, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 6, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 6, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 6, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 6, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 6, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 6, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 6, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 6, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 6, 30, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 6, 30, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 6, 30, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 6, 30, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 6, 30, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 6, 30, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 6, 30, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 6, 30, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 6, 30, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 1, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 1, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 1, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 1, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 1, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 1, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 1, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 1, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 1, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 2, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 2, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 2, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 2, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 2, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 2, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 2, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 2, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 2, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 3, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 3, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 3, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 3, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 3, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 3, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 3, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 3, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 3, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 4, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 5, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 5, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 5, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 5, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 5, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 5, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 5, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 5, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 5, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 6, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 6, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 6, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 6, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 6, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 6, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 6, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 6, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 6, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 7, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 7, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 7, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 7, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 7, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 7, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 7, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 7, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 7, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 8, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 8, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 8, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 8, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 8, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 8, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 8, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 8, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 8, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 9, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 9, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 9, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 9, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 9, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 9, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 9, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 9, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 9, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 10, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 10, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 10, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 10, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 10, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 10, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 10, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 10, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 10, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 11, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 11, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 11, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 11, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 11, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 11, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 11, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 11, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 11, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 12, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 12, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 12, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 12, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 12, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 12, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 12, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 12, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 12, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 13, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 13, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 13, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 13, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 13, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 13, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 13, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 13, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 13, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 14, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 14, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 14, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 14, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 14, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 14, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 14, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 14, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 14, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 15, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 15, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 15, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 15, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 15, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 15, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 15, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 15, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 15, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 16, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 16, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 16, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 16, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 16, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 16, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 16, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 16, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 16, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 17, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 17, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 17, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 17, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 17, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 17, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 17, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 17, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 17, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 18, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 18, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 18, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 18, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 18, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 18, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 18, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 18, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 18, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 19, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 19, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 19, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 19, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 19, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 19, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 19, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 19, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 19, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 20, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 20, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 20, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 20, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 20, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 20, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 20, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 20, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 20, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 21, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 21, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 21, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 21, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 21, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 21, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 21, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 21, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 21, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 22, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 22, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 22, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 22, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 22, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 22, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 22, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 22, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 22, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 23, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 23, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 23, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 23, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 23, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 23, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 23, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 23, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 23, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 24, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 24, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 24, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 24, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 24, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 24, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 24, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 24, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 24, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 25, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 25, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 25, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 25, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 25, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 25, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 25, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 25, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 25, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("08972cfc-c9f9-40fd-8bd9-5cb1a2137512"), new DateTime(2023, 7, 26, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("15116ebd-a590-489b-96f3-f4b87352ceb3"), new DateTime(2023, 7, 26, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 26, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3e3070f2-48d9-4aa4-a760-5654f7d59b14"), new DateTime(2023, 7, 26, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 26, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 26, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 26, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 26, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 26, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 27, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 27, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 27, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 27, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 27, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("cb0d669c-0739-46cb-af7e-135b3c1359ab"), new DateTime(2023, 7, 27, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("d5ebbc22-5405-4a37-94d5-b76cb8dd489a"), new DateTime(2023, 7, 27, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 27, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("ecd856e4-96da-4296-a482-6f66680f1380"), new DateTime(2023, 7, 27, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 28, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("46704eca-2943-4635-ae5b-0b9a4a9fa274"), new DateTime(2023, 7, 28, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("68c22160-dd62-44e3-b9fa-a5285aeed74a"), new DateTime(2023, 7, 28, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 28, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 28, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 28, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 28, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 28, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("dc64720a-db37-48a3-b0d9-da13abec71f7"), new DateTime(2023, 7, 28, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("291a943f-27f5-45ec-b38a-c97f4e2cba89"), new DateTime(2023, 7, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("3bd76d51-384b-4233-a83e-40e1e1a355dc"), new DateTime(2023, 7, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("6a1a286e-7523-4b64-bec5-a5350b4f8169"), new DateTime(2023, 7, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("789fd6e8-ea96-4af7-b417-75284395ceeb"), new DateTime(2023, 7, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("822edebf-23a5-4373-b56d-94078d984192"), new DateTime(2023, 7, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("878d9e51-f7c1-4460-b502-6d3611acc9de"), new DateTime(2023, 7, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("984b9932-5e9b-4bc9-a923-4099f7d488b2"), new DateTime(2023, 7, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("b5459434-2a22-47eb-b993-775edc6f4bf1"), new DateTime(2023, 7, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.DeleteData(
                table: "ChangedsSchedules",
                keyColumns: new[] { "ApplicationUserId", "Date" },
                keyValues: new object[] { new Guid("c6f014d9-2816-4d1d-961f-9d313dbeb2ea"), new DateTime(2023, 7, 29, 19, 23, 7, 426, DateTimeKind.Local).AddTicks(5510) });

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
