using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "ISBN", "Image", "Pages", "PublisherId", "PublishingYear", "Title" },
                values: new object[,]
                {
                    { new Guid("00cce25b-492b-4aaf-bce8-717f1114cd3d"), "J.M. Barrie", "9781503261206", "https://mir-s3-cdn-cf.behance.net/project_modules/hd/35a95226596057.5635798b56b8f.jpg", 198, new Guid("e6dc8da9-4a57-4821-beb3-24117746b333"), 1911, "Peter Pan" },
                    { new Guid("0f13122c-f86f-4383-a35b-839fd0161240"), "Dr. Seuss", "9780394800011", "https://upload.wikimedia.org/wikipedia/en/1/10/The_Cat_in_the_Hat.png", 61, new Guid("5d2db36e-b584-4abf-a093-5b9ffe196486"), 1957, "The Cat in the Hat" },
                    { new Guid("138e4770-b474-4906-a8a5-a32bf2db6704"), "Maurice Sendak", "0060254920", "https://upload.wikimedia.org/wikipedia/en/8/8d/Where_The_Wild_Things_Are_%28book%29_cover.jpg", 48, new Guid("5d2db36e-b584-4abf-a093-5b9ffe196486"), 1963, "Where the Wild Things Are" },
                    { new Guid("228ccec7-4043-41a2-86c2-fddebeb9b9a6"), "Roald Dahl", "9780142410318", "https://m.media-amazon.com/images/I/81Dp5Of3zeL._AC_UF1000,1000_QL80_.jpg", 200, new Guid("e04651b0-5913-4ee7-a691-cdb85933f3ee"), 1964, "Charlie and the Chocolate Factory" },
                    { new Guid("38013e7b-d39e-4c8a-928c-b2299d003f24"), "Kenneth Grahame", "9780141321127", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1630642716i/5659.jpg", 224, new Guid("e04651b0-5913-4ee7-a691-cdb85933f3ee"), 1908, "The Wind in the Willows" },
                    { new Guid("701e0c9e-a0ce-4068-82fc-bf8bc0104fd2"), "Watty Piper", "9780448405209", "https://m.media-amazon.com/images/I/71pf9-VV4NL._AC_UF1000,1000_QL80_.jpg", 48, new Guid("b2b63af9-18b0-48f4-9078-30836e6f54f7"), 1930, "The Little Engine That Could" },
                    { new Guid("721c3f0f-593a-4385-bd83-6a754b4bda80"), "Dr. Seuss", "9780394823379", "https://www.thoughtco.com/thmb/TRDolGdhiKx7SLOZIBPLtIK3ipc=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/lorax-597f13009abed50010c7da1d.jpg", 72, new Guid("b2b63af9-18b0-48f4-9078-30836e6f54f7"), 1971, "The Lorax" },
                    { new Guid("747658a0-9add-4f53-a777-52a10757c027"), "Margaret Wise Brown", "0060775858", "https://m.media-amazon.com/images/I/81E6tmYOD7L._AC_UF1000,1000_QL80_.jpg", 32, new Guid("5d2db36e-b584-4abf-a093-5b9ffe196486"), 1947, "Goodnight Moon" },
                    { new Guid("8ee79623-ccfa-40dc-83c6-7adcb5efc20c"), "Beatrix Potter", "9780723247708", "https://m.media-amazon.com/images/I/61ASCNFMAlL._AC_UF1000,1000_QL80_.jpg", 72, new Guid("1ec7709f-f106-441d-b0d8-dbdc5d06971d"), 1902, "The Tale of Peter Rabbit" },
                    { new Guid("906b1190-c3cd-4290-a003-b3c6cc295d74"), "C.S. Lewis", "9780064471046", "https://m.media-amazon.com/images/I/81QUw81WcoL._AC_UF1000,1000_QL80_.jpg", 208, new Guid("1ec7709f-f106-441d-b0d8-dbdc5d06971d"), 1950, "The Chronicles of Narnia: The Lion, the Witch and the Wardrobe" },
                    { new Guid("979dc70f-b3d1-4c68-bb43-e0e74ebfe94e"), "Dr. Seuss", "9780394800165", "https://m.media-amazon.com/images/I/71e4ln93HOL._AC_UF1000,1000_QL80_.jpg", 62, new Guid("b2b63af9-18b0-48f4-9078-30836e6f54f7"), 1960, "Green Eggs and Ham" },
                    { new Guid("a0d8a706-5957-4bff-888d-8b6a041e9c90"), "E.B. White", "9780061124952", "https://www.artsofimagination.org/wp-content/uploads/2024/01/Charlottes-Web-cover-1.jpeg", 192, new Guid("36bda0c2-9ea8-4c67-a86f-f81486343f12"), 1952, "Charlotte's Web" },
                    { new Guid("a118363d-bdf3-41d7-a2b3-7e0323a2bb89"), "A.A. Milne", "9780525444435", "https://m.media-amazon.com/images/I/61x0v4ZahgL._AC_UF1000,1000_QL80_.jpg", 145, new Guid("bb40bb66-099d-40ff-8994-d5dc15e3d97d"), 1926, "Winnie-the-Pooh" },
                    { new Guid("cde9a74a-b50e-424e-8322-f4204b5a49b3"), "Lewis Carroll", "9781853260025", "https://ik.imagekit.io/panmac/tr:f-auto,di-placeholder_portrait_aMjPtD9YZ.jpg,w-270/edition/9781447279990.jpg", 96, new Guid("bb40bb66-099d-40ff-8994-d5dc15e3d97d"), 1865, "Alice's Adventures in Wonderland" },
                    { new Guid("d34ce8cc-7126-4a77-b82f-c10706cbd2d5"), "L.M. Montgomery", "9780141321592", "https://m.media-amazon.com/images/I/81NDwdjGwSL._AC_UF1000,1000_QL80_.jpg", 320, new Guid("e6dc8da9-4a57-4821-beb3-24117746b333"), 1908, "Anne of Green Gables" },
                    { new Guid("dbbecd36-3ef2-49ea-a962-453496088b22"), "J.K. Rowling", "9780590353427", "https://m.media-amazon.com/images/I/71-++hbbERL._AC_UF894,1000_QL80_.jpg", 320, new Guid("b2b63af9-18b0-48f4-9078-30836e6f54f7"), 1997, "Harry Potter and the Sorcerer's Stone" },
                    { new Guid("ddcda4e6-325a-4e79-9918-796b3918ee13"), "Eric Carle", "0399226907", "https://m.media-amazon.com/images/I/81n9Y6AGy6L._AC_UF1000,1000_QL80_.jpg", 26, new Guid("5d2db36e-b584-4abf-a093-5b9ffe196486"), 1969, "The Very Hungry Caterpillar" },
                    { new Guid("ef8856a6-ecef-4b27-8ed1-6bd832c3c204"), "Frances Hodgson Burnett", "9780064401883", "https://m.media-amazon.com/images/I/91qOXqI3aQL._AC_UF1000,1000_QL80_.jpg", 288, new Guid("e6dc8da9-4a57-4821-beb3-24117746b333"), 1911, "The Secret Garden" },
                    { new Guid("ff2322c8-b5d6-4ed6-a4c0-4df7ff58e706"), "Julia Donaldson", "9780142403877", "https://cdn.ozone.bg/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/t/h/ad8a2ed668a51de9d6a0945e6ab4c650/the-gruffalo-30.jpg", 32, new Guid("36bda0c2-9ea8-4c67-a86f-f81486343f12"), 1999, "The Gruffalo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00cce25b-492b-4aaf-bce8-717f1114cd3d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0f13122c-f86f-4383-a35b-839fd0161240"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("138e4770-b474-4906-a8a5-a32bf2db6704"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("228ccec7-4043-41a2-86c2-fddebeb9b9a6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("38013e7b-d39e-4c8a-928c-b2299d003f24"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("701e0c9e-a0ce-4068-82fc-bf8bc0104fd2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("721c3f0f-593a-4385-bd83-6a754b4bda80"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("747658a0-9add-4f53-a777-52a10757c027"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8ee79623-ccfa-40dc-83c6-7adcb5efc20c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("906b1190-c3cd-4290-a003-b3c6cc295d74"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("979dc70f-b3d1-4c68-bb43-e0e74ebfe94e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a0d8a706-5957-4bff-888d-8b6a041e9c90"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a118363d-bdf3-41d7-a2b3-7e0323a2bb89"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cde9a74a-b50e-424e-8322-f4204b5a49b3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d34ce8cc-7126-4a77-b82f-c10706cbd2d5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dbbecd36-3ef2-49ea-a962-453496088b22"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ddcda4e6-325a-4e79-9918-796b3918ee13"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ef8856a6-ecef-4b27-8ed1-6bd832c3c204"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ff2322c8-b5d6-4ed6-a4c0-4df7ff58e706"));
        }
    }
}
