using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pages = table.Column<int>(type: "int", nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishingYear = table.Column<int>(type: "int", nullable: false),
                    PublisherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => new { x.UserId, x.BookId });
                    table.ForeignKey(
                        name: "FK_Favorites_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favorites_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserBooks",
                columns: table => new
                {
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBooks", x => new { x.UserId, x.BookId });
                    table.ForeignKey(
                        name: "FK_UserBooks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1ec7709f-f106-441d-b0d8-dbdc5d06971d"), "Free Spirit Publishing" },
                    { new Guid("36bda0c2-9ea8-4c67-a86f-f81486343f12"), "Arbordale Publishing" },
                    { new Guid("5d24ced7-7e83-4dae-9b60-d559d9d96bb0"), "Chronicle Books" },
                    { new Guid("5d2db36e-b584-4abf-a093-5b9ffe196486"), "Albert Whitman" },
                    { new Guid("931e6d94-1fc5-4af1-a722-f05bde8c64f9"), "August House" },
                    { new Guid("b2b63af9-18b0-48f4-9078-30836e6f54f7"), "Candlewick Press" },
                    { new Guid("bb40bb66-099d-40ff-8994-d5dc15e3d97d"), "Kids Can Press" },
                    { new Guid("e04651b0-5913-4ee7-a691-cdb85933f3ee"), "Flying Eye Books" },
                    { new Guid("e6dc8da9-4a57-4821-beb3-24117746b333"), "Quirk Books" },
                    { new Guid("ea3480ae-657b-4bcf-ac44-8e45081b58e6"), "Holiday House" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "ISBN", "Image", "Pages", "Price", "PublisherId", "PublishingYear", "Title" },
                values: new object[,]
                {
                    { new Guid("00cce25b-492b-4aaf-bce8-717f1114cd3d"), "J.M. Barrie", "9781503261206", "https://mir-s3-cdn-cf.behance.net/project_modules/hd/35a95226596057.5635798b56b8f.jpg", 198, "20,00", new Guid("e6dc8da9-4a57-4821-beb3-24117746b333"), 1911, "Peter Pan" },
                    { new Guid("0f13122c-f86f-4383-a35b-839fd0161240"), "Dr. Seuss", "9780394800011", "https://upload.wikimedia.org/wikipedia/en/1/10/The_Cat_in_the_Hat.png", 61, "12,10", new Guid("5d2db36e-b584-4abf-a093-5b9ffe196486"), 1957, "The Cat in the Hat" },
                    { new Guid("138e4770-b474-4906-a8a5-a32bf2db6704"), "Maurice Sendak", "0060254920", "https://upload.wikimedia.org/wikipedia/en/8/8d/Where_The_Wild_Things_Are_%28book%29_cover.jpg", 48, "12,10", new Guid("5d2db36e-b584-4abf-a093-5b9ffe196486"), 1963, "Where the Wild Things Are" },
                    { new Guid("16236379-7fd8-4f8e-b513-cef865dec7f7"), "Chris Van Allsburg", "9780395389492", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1638557399i/420282.jpg", 32, "20,10", new Guid("5d24ced7-7e83-4dae-9b60-d559d9d96bb0"), 1985, "The Polar Express" },
                    { new Guid("228ccec7-4043-41a2-86c2-fddebeb9b9a6"), "Roald Dahl", "9780142410318", "https://m.media-amazon.com/images/I/81Dp5Of3zeL._AC_UF1000,1000_QL80_.jpg", 200, "17,00", new Guid("e04651b0-5913-4ee7-a691-cdb85933f3ee"), 1964, "Charlie and the Chocolate Factory" },
                    { new Guid("2d48162d-6e09-4648-8019-f584c51dd3c6"), "P.D. Eastman", "9780394800188", "https://m.media-amazon.com/images/I/61GO+cnyq5L._AC_UF1000,1000_QL80_.jpg", 72, "20,00", new Guid("e6dc8da9-4a57-4821-beb3-24117746b333"), 1960, "Are You My Mother?" },
                    { new Guid("30e10c71-f5a8-4065-ad1a-fa6439cac32e"), "Shel Silverstein", "9780060256654", "https://m.media-amazon.com/images/I/71wiGMKadmL._AC_UF1000,1000_QL80_.jpg", 64, "12,10", new Guid("b2b63af9-18b0-48f4-9078-30836e6f54f7"), 1964, "The Giving Tree" },
                    { new Guid("38013e7b-d39e-4c8a-928c-b2299d003f24"), "Kenneth Grahame", "9780141321127", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1630642716i/5659.jpg", 224, "10,00", new Guid("e04651b0-5913-4ee7-a691-cdb85933f3ee"), 1908, "The Wind in the Willows" },
                    { new Guid("41b480b1-02da-4c00-bc77-759879c25a99"), "Margery Williams", "9780380002559", "https://m.media-amazon.com/images/I/81+AkzSB5hL._AC_UF1000,1000_QL80_.jpg", 48, "10,10", new Guid("e04651b0-5913-4ee7-a691-cdb85933f3ee"), 1922, "The Velveteen Rabbit" },
                    { new Guid("5b0325cc-f96c-408c-98de-caf886ec12ab"), "Marcus Pfister", "9781558580091", "https://m.media-amazon.com/images/I/91pdllYEUfL._AC_UF1000,1000_QL80_.jpg", 24, "12,10", new Guid("bb40bb66-099d-40ff-8994-d5dc15e3d97d"), 1992, "The Rainbow Fish" },
                    { new Guid("701e0c9e-a0ce-4068-82fc-bf8bc0104fd2"), "Watty Piper", "9780448405209", "https://m.media-amazon.com/images/I/71pf9-VV4NL._AC_UF1000,1000_QL80_.jpg", 48, "20,00", new Guid("b2b63af9-18b0-48f4-9078-30836e6f54f7"), 1930, "The Little Engine That Could" },
                    { new Guid("721c3f0f-593a-4385-bd83-6a754b4bda80"), "Dr. Seuss", "9780394823379", "https://www.thoughtco.com/thmb/TRDolGdhiKx7SLOZIBPLtIK3ipc=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/lorax-597f13009abed50010c7da1d.jpg", 72, "15,10", new Guid("b2b63af9-18b0-48f4-9078-30836e6f54f7"), 1971, "The Lorax" },
                    { new Guid("747658a0-9add-4f53-a777-52a10757c027"), "Margaret Wise Brown", "0060775858", "https://m.media-amazon.com/images/I/81E6tmYOD7L._AC_UF1000,1000_QL80_.jpg", 32, "20,00", new Guid("5d2db36e-b584-4abf-a093-5b9ffe196486"), 1947, "Goodnight Moon" },
                    { new Guid("7ffbf854-8c14-4c02-afac-c3e30e3d7207"), "Norman Bridwell", "9780545215787", "https://m.media-amazon.com/images/I/81TU2o5NYOL._AC_UF1000,1000_QL80_.jpg", 32, "12,10", new Guid("5d24ced7-7e83-4dae-9b60-d559d9d96bb0"), 1963, "Clifford the Big Red Dog" },
                    { new Guid("8237018b-97f0-4b42-8f10-4b545560f8be"), "Ezra Jack Keats", "9780670867332", "https://m.media-amazon.com/images/I/71Ku1Uk6VqL._AC_UF1000,1000_QL80_.jpg", 40, "12,00", new Guid("bb40bb66-099d-40ff-8994-d5dc15e3d97d"), 1962, "The Snowy Day" },
                    { new Guid("8c4a4908-7a5c-4364-ab4c-689deb411ccf"), "Don Freeman", "9780140501735", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1347517273i/231850.jpg", 32, "25,00", new Guid("bb40bb66-099d-40ff-8994-d5dc15e3d97d"), 1968, "Corduroy" },
                    { new Guid("8ee79623-ccfa-40dc-83c6-7adcb5efc20c"), "Beatrix Potter", "9780723247708", "https://m.media-amazon.com/images/I/61ASCNFMAlL._AC_UF1000,1000_QL80_.jpg", 72, "18,00", new Guid("1ec7709f-f106-441d-b0d8-dbdc5d06971d"), 1902, "The Tale of Peter Rabbit" },
                    { new Guid("906b1190-c3cd-4290-a003-b3c6cc295d74"), "C.S. Lewis", "9780064471046", "https://m.media-amazon.com/images/I/81QUw81WcoL._AC_UF1000,1000_QL80_.jpg", 208, "30,00", new Guid("1ec7709f-f106-441d-b0d8-dbdc5d06971d"), 1950, "The Chronicles of Narnia: The Lion, the Witch and the Wardrobe" },
                    { new Guid("91edf706-93ce-4695-81d2-e8db8212618b"), "Ludwig Bemelmans", "9780140564396", "https://upload.wikimedia.org/wikipedia/en/1/19/Madeline-1939.jpg", 56, "25,00", new Guid("5d24ced7-7e83-4dae-9b60-d559d9d96bb0"), 1939, "Madeline" },
                    { new Guid("944d2a25-9509-45f1-ba05-e65095a8b5f8"), "E.B. White", "9780064400565", "https://m.media-amazon.com/images/I/91a1ogh+5JL._AC_UF1000,1000_QL80_.jpg", 144, "17,00", new Guid("36bda0c2-9ea8-4c67-a86f-f81486343f12"), 1945, "Stuart Little" },
                    { new Guid("979dc70f-b3d1-4c68-bb43-e0e74ebfe94e"), "Dr. Seuss", "9780394800165", "https://m.media-amazon.com/images/I/71e4ln93HOL._AC_UF1000,1000_QL80_.jpg", 62, "35,00", new Guid("b2b63af9-18b0-48f4-9078-30836e6f54f7"), 1960, "Green Eggs and Ham" },
                    { new Guid("a0d8a706-5957-4bff-888d-8b6a041e9c90"), "E.B. White", "9780061124952", "https://www.artsofimagination.org/wp-content/uploads/2024/01/Charlottes-Web-cover-1.jpeg", 192, "20,00", new Guid("36bda0c2-9ea8-4c67-a86f-f81486343f12"), 1952, "Charlotte's Web" },
                    { new Guid("a118363d-bdf3-41d7-a2b3-7e0323a2bb89"), "A.A. Milne", "9780525444435", "https://m.media-amazon.com/images/I/61x0v4ZahgL._AC_UF1000,1000_QL80_.jpg", 145, "25,00", new Guid("bb40bb66-099d-40ff-8994-d5dc15e3d97d"), 1926, "Winnie-the-Pooh" },
                    { new Guid("a1efc311-abe5-4e9c-9220-345211e335f7"), "Beatrix Potter", "9780723247784", "https://m.media-amazon.com/images/I/51YliB2gTfL._AC_UF894,1000_QL80_.jpg", 64, "12,10", new Guid("e6dc8da9-4a57-4821-beb3-24117746b333"), 1908, "The Tale of Jemima Puddle-Duck" },
                    { new Guid("c8d2119d-4cce-4ec9-98b1-66730bfdbd68"), "Laura Numeroff", "9780060245863", "https://m.media-amazon.com/images/I/813csV5cPqL._AC_UF1000,1000_QL80_.jpg", 40, "15,00", new Guid("bb40bb66-099d-40ff-8994-d5dc15e3d97d"), 1985, "If You Give a Mouse a Cookie" },
                    { new Guid("cde9a74a-b50e-424e-8322-f4204b5a49b3"), "Lewis Carroll", "9781853260025", "https://ik.imagekit.io/panmac/tr:f-auto,di-placeholder_portrait_aMjPtD9YZ.jpg,w-270/edition/9781447279990.jpg", 96, "18,10", new Guid("bb40bb66-099d-40ff-8994-d5dc15e3d97d"), 1865, "Alice's Adventures in Wonderland" },
                    { new Guid("d34ce8cc-7126-4a77-b82f-c10706cbd2d5"), "L.M. Montgomery", "9780141321592", "https://m.media-amazon.com/images/I/81NDwdjGwSL._AC_UF1000,1000_QL80_.jpg", 320, "15,00", new Guid("e6dc8da9-4a57-4821-beb3-24117746b333"), 1908, "Anne of Green Gables" },
                    { new Guid("dbbecd36-3ef2-49ea-a962-453496088b22"), "J.K. Rowling", "9780590353427", "https://m.media-amazon.com/images/I/71-++hbbERL._AC_UF894,1000_QL80_.jpg", 320, "17,00", new Guid("b2b63af9-18b0-48f4-9078-30836e6f54f7"), 1997, "Harry Potter and the Sorcerer's Stone" },
                    { new Guid("ddcda4e6-325a-4e79-9918-796b3918ee13"), "Eric Carle", "0399226907", "https://m.media-amazon.com/images/I/81n9Y6AGy6L._AC_UF1000,1000_QL80_.jpg", 26, "25,00", new Guid("5d2db36e-b584-4abf-a093-5b9ffe196486"), 1969, "The Very Hungry Caterpillar" },
                    { new Guid("e2ae75e8-7405-401f-945d-9539e98a50bd"), "Bill Martin Jr.", "9780805047905", "https://m.media-amazon.com/images/I/81Ukrj-NTgL._AC_UF1000,1000_QL80_.jpg", 28, "15,00", new Guid("5d24ced7-7e83-4dae-9b60-d559d9d96bb0"), 1967, "Brown Bear, Brown Bear, What Do You See?" },
                    { new Guid("ef8856a6-ecef-4b27-8ed1-6bd832c3c204"), "Frances Hodgson Burnett", "9780064401883", "https://m.media-amazon.com/images/I/91qOXqI3aQL._AC_UF1000,1000_QL80_.jpg", 288, "17,10", new Guid("e6dc8da9-4a57-4821-beb3-24117746b333"), 1911, "The Secret Garden" },
                    { new Guid("efb48636-3c8c-44b2-9fab-160c3a172e9f"), "Bill Martin Jr. and John Archambault", "9781442450707", "https://m.media-amazon.com/images/I/61rGNycNKbL._AC_UF1000,1000_QL80_.jpg", 40, "15,10", new Guid("5d24ced7-7e83-4dae-9b60-d559d9d96bb0"), 1989, "Chicka Chicka Boom Boom" },
                    { new Guid("fd6a4340-079f-4890-a06f-367021cf840a"), "Robert Munsch", "9780920236161", "https://m.media-amazon.com/images/I/71fZdpPbIML._AC_UF1000,1000_QL80_.jpg", 32, "15,00", new Guid("e04651b0-5913-4ee7-a691-cdb85933f3ee"), 1980, "The Paper Bag Princess" },
                    { new Guid("ff2322c8-b5d6-4ed6-a4c0-4df7ff58e706"), "Julia Donaldson", "9780142403877", "https://cdn.ozone.bg/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/t/h/ad8a2ed668a51de9d6a0945e6ab4c650/the-gruffalo-30.jpg", 32, "15,50", new Guid("36bda0c2-9ea8-4c67-a86f-f81486343f12"), 1999, "The Gruffalo" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_BookId",
                table: "Favorites",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBooks_BookId",
                table: "UserBooks",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "UserBooks");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
