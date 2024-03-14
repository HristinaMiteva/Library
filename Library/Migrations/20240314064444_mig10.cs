using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class mig10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "ISBN", "Image", "Pages", "PublisherId", "PublishingYear", "Title" },
                values: new object[,]
                {
                    { new Guid("16236379-7fd8-4f8e-b513-cef865dec7f7"), "Chris Van Allsburg", "9780395389492", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1638557399i/420282.jpg", 32, new Guid("5d24ced7-7e83-4dae-9b60-d559d9d96bb0"), 1985, "The Polar Express" },
                    { new Guid("2d48162d-6e09-4648-8019-f584c51dd3c6"), "P.D. Eastman", "9780394800188", "https://m.media-amazon.com/images/I/61GO+cnyq5L._AC_UF1000,1000_QL80_.jpg", 72, new Guid("e6dc8da9-4a57-4821-beb3-24117746b333"), 1960, "Are You My Mother?" },
                    { new Guid("30e10c71-f5a8-4065-ad1a-fa6439cac32e"), "Shel Silverstein", "9780060256654", "https://m.media-amazon.com/images/I/71wiGMKadmL._AC_UF1000,1000_QL80_.jpg", 64, new Guid("b2b63af9-18b0-48f4-9078-30836e6f54f7"), 1964, "The Giving Tree" },
                    { new Guid("41b480b1-02da-4c00-bc77-759879c25a99"), "Margery Williams", "9780380002559", "https://m.media-amazon.com/images/I/81+AkzSB5hL._AC_UF1000,1000_QL80_.jpg", 48, new Guid("e04651b0-5913-4ee7-a691-cdb85933f3ee"), 1922, "The Velveteen Rabbit" },
                    { new Guid("5b0325cc-f96c-408c-98de-caf886ec12ab"), "Marcus Pfister", "9781558580091", "https://m.media-amazon.com/images/I/91pdllYEUfL._AC_UF1000,1000_QL80_.jpg", 24, new Guid("bb40bb66-099d-40ff-8994-d5dc15e3d97d"), 1992, "The Rainbow Fish" },
                    { new Guid("7ffbf854-8c14-4c02-afac-c3e30e3d7207"), "Norman Bridwell", "9780545215787", "https://m.media-amazon.com/images/I/81TU2o5NYOL._AC_UF1000,1000_QL80_.jpg", 32, new Guid("5d24ced7-7e83-4dae-9b60-d559d9d96bb0"), 1963, "Clifford the Big Red Dog" },
                    { new Guid("8237018b-97f0-4b42-8f10-4b545560f8be"), "Ezra Jack Keats", "9780670867332", "https://m.media-amazon.com/images/I/71Ku1Uk6VqL._AC_UF1000,1000_QL80_.jpg", 40, new Guid("bb40bb66-099d-40ff-8994-d5dc15e3d97d"), 1962, "The Snowy Day" },
                    { new Guid("8c4a4908-7a5c-4364-ab4c-689deb411ccf"), "Don Freeman", "9780140501735", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1347517273i/231850.jpg", 32, new Guid("bb40bb66-099d-40ff-8994-d5dc15e3d97d"), 1968, "Corduroy" },
                    { new Guid("91edf706-93ce-4695-81d2-e8db8212618b"), "Ludwig Bemelmans", "9780140564396", "https://upload.wikimedia.org/wikipedia/en/1/19/Madeline-1939.jpg", 56, new Guid("5d24ced7-7e83-4dae-9b60-d559d9d96bb0"), 1939, "Madeline" },
                    { new Guid("944d2a25-9509-45f1-ba05-e65095a8b5f8"), "E.B. White", "9780064400565", "https://m.media-amazon.com/images/I/91a1ogh+5JL._AC_UF1000,1000_QL80_.jpg", 144, new Guid("36bda0c2-9ea8-4c67-a86f-f81486343f12"), 1945, "Stuart Little" },
                    { new Guid("a1efc311-abe5-4e9c-9220-345211e335f7"), "Beatrix Potter", "9780723247784", "https://m.media-amazon.com/images/I/51YliB2gTfL._AC_UF894,1000_QL80_.jpg", 64, new Guid("e6dc8da9-4a57-4821-beb3-24117746b333"), 1908, "The Tale of Jemima Puddle-Duck" },
                    { new Guid("c8d2119d-4cce-4ec9-98b1-66730bfdbd68"), "Laura Numeroff", "9780060245863", "https://m.media-amazon.com/images/I/813csV5cPqL._AC_UF1000,1000_QL80_.jpg", 40, new Guid("bb40bb66-099d-40ff-8994-d5dc15e3d97d"), 1985, "If You Give a Mouse a Cookie" },
                    { new Guid("e2ae75e8-7405-401f-945d-9539e98a50bd"), "Bill Martin Jr.", "9780805047905", "https://m.media-amazon.com/images/I/81Ukrj-NTgL._AC_UF1000,1000_QL80_.jpg", 28, new Guid("5d24ced7-7e83-4dae-9b60-d559d9d96bb0"), 1967, "Brown Bear, Brown Bear, What Do You See?" },
                    { new Guid("efb48636-3c8c-44b2-9fab-160c3a172e9f"), "Bill Martin Jr. and John Archambault", "9781442450707", "https://m.media-amazon.com/images/I/61rGNycNKbL._AC_UF1000,1000_QL80_.jpg", 40, new Guid("5d24ced7-7e83-4dae-9b60-d559d9d96bb0"), 1989, "Chicka Chicka Boom Boom" },
                    { new Guid("fd6a4340-079f-4890-a06f-367021cf840a"), "Robert Munsch", "9780920236161", "https://m.media-amazon.com/images/I/71fZdpPbIML._AC_UF1000,1000_QL80_.jpg", 32, new Guid("e04651b0-5913-4ee7-a691-cdb85933f3ee"), 1980, "The Paper Bag Princess" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("16236379-7fd8-4f8e-b513-cef865dec7f7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2d48162d-6e09-4648-8019-f584c51dd3c6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("30e10c71-f5a8-4065-ad1a-fa6439cac32e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("41b480b1-02da-4c00-bc77-759879c25a99"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5b0325cc-f96c-408c-98de-caf886ec12ab"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7ffbf854-8c14-4c02-afac-c3e30e3d7207"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8237018b-97f0-4b42-8f10-4b545560f8be"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8c4a4908-7a5c-4364-ab4c-689deb411ccf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("91edf706-93ce-4695-81d2-e8db8212618b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("944d2a25-9509-45f1-ba05-e65095a8b5f8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a1efc311-abe5-4e9c-9220-345211e335f7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c8d2119d-4cce-4ec9-98b1-66730bfdbd68"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e2ae75e8-7405-401f-945d-9539e98a50bd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("efb48636-3c8c-44b2-9fab-160c3a172e9f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fd6a4340-079f-4890-a06f-367021cf840a"));
        }
    }
}
