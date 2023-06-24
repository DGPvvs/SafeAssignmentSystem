using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SafeAssignmentSystem.DataBase.Migrations
{
    public partial class SeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserWorkNumber" },
                values: new object[,]
                {
                    { "08972cfc-c9f9-40fd-8bd9-5cb1a2137512", 0, "c422cffd-793a-4270-bc50-aebb7af39ab9", null, false, "Столипен", "Тонев", false, null, null, "STOLIPEN.TONEV", "AQAAAAEAACcQAAAAEPHYwQjRigzh7RDgCtZXQdw3t5ZAgsxHsgsPXRNdMxfH4eU7wRYmNuTLnlK/adohNg==", null, false, "4472ced2-dfd8-4365-b044-fc2142e44090", false, "Stolipen.Tonev", 38744 },
                    { "15116ebd-a590-489b-96f3-f4b87352ceb3", 0, "8ba20df1-fbca-44d7-b808-6be56a6b4f7b", null, false, "Жерар", "Славчев", false, null, null, "GERAR.SLAVTCHEV", "AQAAAAEAACcQAAAAENp9YL+nAKrsDNp/AI+Gsc0FSdrY/EBFEzaALRQ65LHOsSOQM1M4J3WxNDeniKt5jw==", null, false, "07b6b578-6efc-45d7-9f4a-55cf842bc209", false, "Gerar.Slavtchev", 45571 },
                    { "291a943f-27f5-45ec-b38a-c97f4e2cba89", 0, "4daddd9d-9f19-46c2-964d-f0c134c63272", null, false, "Лазо", "Шишманов", false, null, null, "LAZO.CHICHMANOV", "AQAAAAEAACcQAAAAEN/dB7/pM/LsCKw0eUFjJGIh4VikbnUYhlAfJZquamLQxtULGpn++80kSVtINdk8cw==", null, false, "ebd8340c-b8df-414b-9af1-a7a9dc17e234", false, "Lazo.Chichmanov", 68340 },
                    { "3bd76d51-384b-4233-a83e-40e1e1a355dc", 0, "ae7f0aff-0fb0-4a08-b024-5f158cfb20a3", null, false, "Дан", "Игнатов", false, null, null, "IGNATOV.DAN", "AQAAAAEAACcQAAAAEKolujeKP20XM/wBB2X6+frY5jWGMJ535VFTfS/YYGXwmNu0wpBwL5DA51YFk6VcbQ==", null, false, "88728c8c-3c97-4f3d-8484-3690c7f16817", false, "Ignatov.Dan", 88327 },
                    { "3e3070f2-48d9-4aa4-a760-5654f7d59b14", 0, "d4f59425-4686-4c06-bdf6-6c17cf3459e5", null, false, "Флоро", "Станов", false, null, null, "FLORO.STANOV", "AQAAAAEAACcQAAAAENceFofDAAe8NZF/TL34PMX/3Tp/CL0EZyWbKD3WA3r/5nOwq2VMfpjvuxEgrFVFnw==", null, false, "7a8d3f05-7a69-49d0-bc48-6855292cd16c", false, "Floro.Stanov", 71417 },
                    { "46704eca-2943-4635-ae5b-0b9a4a9fa274", 0, "d56e74d2-fcb9-4ec0-b1ee-f76059d3e4f1", null, false, "Руси", "Магичов", false, null, null, "RUSI.MAGITCHOV", "AQAAAAEAACcQAAAAEBw51AE1V918CNxrSyBeNfeYL8nYjoe1Gs9cEinfUw2O/ngtG8Lxa/BG/nL1bYK1Qg==", null, false, "96441461-a19c-419d-9c2f-e99dab151cf6", false, "Rusi.Magitchov", 44454 },
                    { "68c22160-dd62-44e3-b9fa-a5285aeed74a", 0, "47324b8a-8cd6-43f6-9f88-ba0ffd317f7c", null, false, "Дарен", "Павков", false, null, null, "DAREN.PAVKOV", "AQAAAAEAACcQAAAAEHCYfhgm2hyjkx+28UVzBGlBxBebxZHEmB/ZbnkZT9/o7K2YDcqolJUynGCcpC7mKw==", null, false, "8ca3e768-722e-45bd-a1ad-10377a213ad4", false, "Daren.Pavkov", 98129 },
                    { "6a1a286e-7523-4b64-bec5-a5350b4f8169", 0, "8f415a7b-d291-462f-b3b4-afd964c281ad", null, false, "Данимил", "Тинков", false, null, null, "DANIMIL.TINKOV", "AQAAAAEAACcQAAAAEFZxHv7ZcfSXNrLyQFYddWePlpmmDMbudZrhKLfq7Xvkk8WawjEgMQkhPJIqQM/nKg==", null, false, "7e5f4f8d-9726-41e1-b0c9-a9004c7559f3", false, "Danimil.Tinkov", 70677 },
                    { "789fd6e8-ea96-4af7-b417-75284395ceeb", 0, "188ef6a6-e52c-4494-a4ea-f175aa643385", null, false, "Сергей", "Попов", false, null, null, "POPOV.SERGEY", "AQAAAAEAACcQAAAAED7EI5cQp56QxqWZq5EVUUXYWA1sCTDUbUT4BtR/nzs2+ldQj89l3+T0Dn8gmNZoUQ==", null, false, "1aaa77f8-6021-4575-b3b5-e6e2ec4dca82", false, "Popov.Sergey", 38011 },
                    { "822edebf-23a5-4373-b56d-94078d984192", 0, "1c49e2b3-d51e-4352-9e1a-90367181ad9b", null, false, "Пейо", "Ленков", false, null, null, "PEYO.LENKOV", "AQAAAAEAACcQAAAAEAAjavQ9okXYr+Cs+MQeIWnWDTVh5OEyd5U/eWkwBWGzDfbMoY+gFevLrTS70kCIhQ==", null, false, "d5a58bb7-9b23-401b-b59d-d310c8c8ea02", false, "Peyo.Lenkov", 62230 },
                    { "878d9e51-f7c1-4460-b502-6d3611acc9de", 0, "ba554540-7595-4b8c-82af-178593a560e2", null, false, "Аню", "Панчев", false, null, null, "ANUY.PANTCHEV", "AQAAAAEAACcQAAAAEJVdvkQU9ALSGXcHux8XD+kifz0vPshU30WSagZ0FJITUbNqPwCln//9jKUcKayhhg==", null, false, "eac83d0f-1e04-4cd9-beba-93ffdd400491", false, "Anuy.Pantchev", 65072 },
                    { "984b9932-5e9b-4bc9-a923-4099f7d488b2", 0, "7533d07d-e2f1-4813-80ff-d6bd845c1a74", null, false, "Друмчо", "Светозаров", false, null, null, "DRUMTCHO.SVETOZAROV", "AQAAAAEAACcQAAAAELlSe8btFiyCTT5mDMmcf1rLMZsc6BcXOISjA0Ya4E6VqYqmb7qq8J4747Hfjhkk3w==", null, false, "2a855da8-be0f-4d49-b679-66c505be5d5a", false, "Drumtcho.Svetozarov", 35236 },
                    { "b5459434-2a22-47eb-b993-775edc6f4bf1", 0, "40736c5a-4f53-487e-b027-5be4179da82c", null, false, "Дориян", "Славейков", false, null, null, "DORIYAN.SLAVEYKOV", "AQAAAAEAACcQAAAAEGmJrHQ+u7O9moTVhxAwYzQjmNho8ULbQP5dltyfq8RCkLl6egGhp4HDZltBuBLG9w==", null, false, "b59d31e9-53e5-49a3-92c3-164d0c2ab728", false, "Doriyan.Slaveykov", 39676 },
                    { "c6f014d9-2816-4d1d-961f-9d313dbeb2ea", 0, "05977fb4-e6b6-4f36-9d8f-b033328f4daf", null, false, "Менко", "Мирков", false, null, null, "MENKO.MIRKOV", "AQAAAAEAACcQAAAAEA33MW6VLw7DjjuJZgOAcIQfQj4CM6KvRi8+NEftI83Su/H0DhYdR6cz7enCDIxgaA==", null, false, "c6916b2b-98bb-46a0-a07e-d2e2c16fe842", false, "Menko.Mirkov", 19386 },
                    { "cb0d669c-0739-46cb-af7e-135b3c1359ab", 0, "00467844-efc0-4e5c-8c06-ce0f72449416", null, false, "Силвиян", "Янов", false, null, null, "SILVIYAN.YANKOV", "AQAAAAEAACcQAAAAEBhMTIQx2JL7VMS74MsYqgyyc2yIfLOlPewDU/bcUfM7wDXBDeDomV6dvg7/OZu4rA==", null, false, "68ef19f7-cfc8-46ba-9d2c-7350e8834810", false, "Silviyan.Yankov", 52291 },
                    { "d5ebbc22-5405-4a37-94d5-b76cb8dd489a", 0, "a5eb196f-0d0b-4069-9585-b4cf8c793719", null, false, "Драгни", "Тодоров", false, null, null, "DRAGNI.TODOROV", "AQAAAAEAACcQAAAAEByxh+Ez66EnmLOuYYR3AIJz9BMkYOteWLhvwkRUciS9JO4ZTn4TWx+MO/DIi7uzzQ==", null, false, "622387dd-c119-4533-9d02-a23dc4e10c43", false, "Dragni.Todorov", 80738 },
                    { "dc64720a-db37-48a3-b0d9-da13abec71f7", 0, "8b09d10c-71ae-49ec-b399-4e4f71a1c919", null, false, "Доко", "Цанимиров", false, null, null, "DOKO.TSANIMIROV", "AQAAAAEAACcQAAAAEAbWdiIwHgeSgF4H7aERDUNkbHQodU+n/BvsMOi/VgOphNnKGwxl5Z0Tq/WQYPSIXQ==", null, false, "fa5693e3-f77e-4c83-bd94-74397ba1b4c4", false, "Doko.Tsanimirov", 46929 },
                    { "ecd856e4-96da-4296-a482-6f66680f1380", 0, "30ee0efa-7e6a-4909-a23f-1738d14686a4", null, false, "Биню", "Тошков", false, null, null, "BINUY.TOCHKOV", "AQAAAAEAACcQAAAAECD46nOfGfc+XGBQ0F05KIShuK+ZxfXy1mM8xTT/zY/Lhmfyh7l1tBZekB7LXEcWGQ==", null, false, "51bab9d3-70ad-4882-b3b8-288f9bbb16dd", false, "Binuy.Tochkov", 61815 },
                    { "f91c5b35-506c-4987-a89a-fba703b53f03", 0, "8d79fc52-b24f-40a1-8b84-4cb2d3aee1f6", null, false, "Захари", "Тодеев", false, null, null, "ZAHARI.TODEEV", "AQAAAAEAACcQAAAAEAbjYbZOjHOg6uHR7VGqUE6QZ81jaQtKZJAXbbMMOEnjjOqTw95XQ4+MoSPoRxfIXw==", null, false, "4bbb874c-81dc-448e-bfc3-7ad3335872ea", false, "Zahari.Todeev", 50975 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f91c5b35-506c-4987-a89a-fba703b53f03");
        }
    }
}
