using Library.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(CreateBooks());
        }
        private List<Book>CreateBooks()
         {
             List<Book> books = new List<Book>();
            Book book = new Book()
            {
                Id = Guid.Parse("138e4770-b474-4906-a8a5-a32bf2db6704"),
                Title = "Where the Wild Things Are",
                Author = "Maurice Sendak",
                Pages = 48,
                ISBN = "0060254920",
                Price=12.10,
                Image = "https://upload.wikimedia.org/wikipedia/en/8/8d/Where_The_Wild_Things_Are_%28book%29_cover.jpg",
                PublishingYear = 1963,
                PublisherId = Guid.Parse("5d2db36e-b584-4abf-a093-5b9ffe196486")
            };

             books.Add(book);

             book = new Book()
             {
                 Id = Guid.Parse("ddcda4e6-325a-4e79-9918-796b3918ee13"),
                 Title = "The Very Hungry Caterpillar",
                 Author = "Eric Carle",
                 Pages = 26,
                 ISBN = "0399226907",
                 Price = 25,
                 Image = "https://m.media-amazon.com/images/I/81n9Y6AGy6L._AC_UF1000,1000_QL80_.jpg",
                 PublishingYear = 1969,
                 PublisherId = Guid.Parse("5d2db36e-b584-4abf-a093-5b9ffe196486")
             };
             books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("747658a0-9add-4f53-a777-52a10757c027"),
                Title = "Goodnight Moon",
                Author = "Margaret Wise Brown",
                Pages = 32,
                ISBN = "0060775858",
                Price = 20,
                Image = "https://m.media-amazon.com/images/I/81E6tmYOD7L._AC_UF1000,1000_QL80_.jpg",
                PublishingYear = 1947,
                PublisherId = Guid.Parse("5d2db36e-b584-4abf-a093-5b9ffe196486")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("0f13122c-f86f-4383-a35b-839fd0161240"),
                Title = "The Cat in the Hat",
                Author = "Dr. Seuss",
                Pages = 61,
                ISBN = "9780394800011",
                Price = 12.10,
                Image = "https://upload.wikimedia.org/wikipedia/en/1/10/The_Cat_in_the_Hat.png",
                PublishingYear = 1957,
                PublisherId = Guid.Parse("5d2db36e-b584-4abf-a093-5b9ffe196486")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("979dc70f-b3d1-4c68-bb43-e0e74ebfe94e"),
                Title = "Green Eggs and Ham",
                Author = "Dr. Seuss",
                Pages = 62,
                ISBN = "9780394800165",
                Price = 35,
                Image = "https://m.media-amazon.com/images/I/71e4ln93HOL._AC_UF1000,1000_QL80_.jpg",
                PublishingYear = 1960,
                PublisherId = Guid.Parse("b2b63af9-18b0-48f4-9078-30836e6f54f7")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("dbbecd36-3ef2-49ea-a962-453496088b22"),
                Title = "Harry Potter and the Sorcerer's Stone",
                Author = "J.K. Rowling",
                Pages = 320,
                ISBN = "9780590353427",
                Price = 17,
                Image = "https://m.media-amazon.com/images/I/71-++hbbERL._AC_UF894,1000_QL80_.jpg",
                PublishingYear = 1997,
                PublisherId = Guid.Parse("b2b63af9-18b0-48f4-9078-30836e6f54f7")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("ff2322c8-b5d6-4ed6-a4c0-4df7ff58e706"),
                Title = "The Gruffalo",
                Author = "Julia Donaldson",
                Pages = 32,
                ISBN = "9780142403877",
                Price = 15.50,
                Image = "https://cdn.ozone.bg/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/t/h/ad8a2ed668a51de9d6a0945e6ab4c650/the-gruffalo-30.jpg",
                PublishingYear = 1999,
                PublisherId = Guid.Parse("36bda0c2-9ea8-4c67-a86f-f81486343f12")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("a0d8a706-5957-4bff-888d-8b6a041e9c90"),
                Title = "Charlotte's Web",
                Author = "E.B. White",
                Pages = 192,
                ISBN = "9780061124952",
                Price = 20,
                Image = "https://www.artsofimagination.org/wp-content/uploads/2024/01/Charlottes-Web-cover-1.jpeg",
                PublishingYear = 1952,
                PublisherId = Guid.Parse("36bda0c2-9ea8-4c67-a86f-f81486343f12")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("e6b00e91-3180-46c3-b791-86e5cf70e358"),
                Title = "Matilda",
                Author = "Roald Dahl",
                Pages = 240,
                ISBN = "9780142410370",
                Price = 15,
                Image = "https://mir-s3-cdn-cf.behance.net/project_modules/max_1200/fb263953692321.593e14ce61ec4.png",
                PublishingYear = 1988,
                PublisherId = Guid.Parse("1ec7709f-f106-441d-b0d8-dbdc5d06971d")
            };
            book = new Book()
            {
                Id = Guid.Parse("8ee79623-ccfa-40dc-83c6-7adcb5efc20c"),
                Title = "The Tale of Peter Rabbit",
                Author = "Beatrix Potter",
                Pages = 72,
                ISBN = "9780723247708",
                Price = 18,
                Image = "https://m.media-amazon.com/images/I/61ASCNFMAlL._AC_UF1000,1000_QL80_.jpg",
                PublishingYear = 1902,
                PublisherId = Guid.Parse("1ec7709f-f106-441d-b0d8-dbdc5d06971d")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("906b1190-c3cd-4290-a003-b3c6cc295d74"),
                Title = "The Chronicles of Narnia: The Lion, the Witch and the Wardrobe",
                Author = "C.S. Lewis",
                Pages = 208,
                ISBN = "9780064471046",
                Price = 30,
                Image = "https://m.media-amazon.com/images/I/81QUw81WcoL._AC_UF1000,1000_QL80_.jpg",
                PublishingYear = 1950,
                PublisherId = Guid.Parse("1ec7709f-f106-441d-b0d8-dbdc5d06971d")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("cde9a74a-b50e-424e-8322-f4204b5a49b3"),
                Title = "Alice's Adventures in Wonderland",
                Author = "Lewis Carroll",
                Pages = 96,
                ISBN = "9781853260025",
                Price = 18.10,
                Image = "https://ik.imagekit.io/panmac/tr:f-auto,di-placeholder_portrait_aMjPtD9YZ.jpg,w-270/edition/9781447279990.jpg",
                PublishingYear = 1865,
                PublisherId = Guid.Parse("bb40bb66-099d-40ff-8994-d5dc15e3d97d")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("a118363d-bdf3-41d7-a2b3-7e0323a2bb89"),
                Title = "Winnie-the-Pooh",
                Author = "A.A. Milne",
                Pages = 145,
                ISBN = "9780525444435",
                Price = 25,
                Image = "https://m.media-amazon.com/images/I/61x0v4ZahgL._AC_UF1000,1000_QL80_.jpg",
                PublishingYear = 1926,
                PublisherId = Guid.Parse("bb40bb66-099d-40ff-8994-d5dc15e3d97d")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("ef8856a6-ecef-4b27-8ed1-6bd832c3c204"),
                Title = "The Secret Garden",
                Author = "Frances Hodgson Burnett",
                Pages = 288,
                ISBN = "9780064401883",
                Price = 17.10,
                Image = "https://m.media-amazon.com/images/I/91qOXqI3aQL._AC_UF1000,1000_QL80_.jpg",
                PublishingYear = 1911,
                PublisherId = Guid.Parse("e6dc8da9-4a57-4821-beb3-24117746b333")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("d34ce8cc-7126-4a77-b82f-c10706cbd2d5"),
                Title = "Anne of Green Gables",
                Author = "L.M. Montgomery",
                Pages = 320,
                ISBN = "9780141321592",
                Price = 15,
                Image = "https://m.media-amazon.com/images/I/81NDwdjGwSL._AC_UF1000,1000_QL80_.jpg",
                PublishingYear = 1908,
                PublisherId = Guid.Parse("e6dc8da9-4a57-4821-beb3-24117746b333")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("00cce25b-492b-4aaf-bce8-717f1114cd3d"),
                Title = "Peter Pan",
                Author = "J.M. Barrie",
                Pages = 198,
                ISBN = "9781503261206",
                Price = 20,
                Image = "https://mir-s3-cdn-cf.behance.net/project_modules/hd/35a95226596057.5635798b56b8f.jpg",
                PublishingYear = 1911,
                PublisherId = Guid.Parse("e6dc8da9-4a57-4821-beb3-24117746b333")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("38013e7b-d39e-4c8a-928c-b2299d003f24"),
                Title = "The Wind in the Willows",
                Author = "Kenneth Grahame",
                Pages = 224,
                ISBN = "9780141321127",
                Price = 10,
                Image = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1630642716i/5659.jpg",
                PublishingYear = 1908,
                PublisherId = Guid.Parse("e04651b0-5913-4ee7-a691-cdb85933f3ee")
            };
            books.Add(book);
            
            book = new Book()
            {
                Id = Guid.Parse("228ccec7-4043-41a2-86c2-fddebeb9b9a6"),
                Title = "Charlie and the Chocolate Factory",
                Author = "Roald Dahl",
                Pages = 200,
                ISBN = "9780142410318",
                Price = 17,
                Image = "https://m.media-amazon.com/images/I/81Dp5Of3zeL._AC_UF1000,1000_QL80_.jpg",
                PublishingYear = 1964,
                PublisherId = Guid.Parse("e04651b0-5913-4ee7-a691-cdb85933f3ee")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("701e0c9e-a0ce-4068-82fc-bf8bc0104fd2"),
                Title = "The Little Engine That Could",
                Author = "Watty Piper",
                Pages = 48,
                ISBN = "9780448405209",
                Price = 20,
                Image = "https://m.media-amazon.com/images/I/71pf9-VV4NL._AC_UF1000,1000_QL80_.jpg",
                PublishingYear = 1930,
                PublisherId = Guid.Parse("b2b63af9-18b0-48f4-9078-30836e6f54f7")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("721c3f0f-593a-4385-bd83-6a754b4bda80"),
                Title = "The Lorax",
                Author = "Dr. Seuss",
                Pages = 72,
                ISBN = "9780394823379",
                Price = 15.10,
                Image = "https://www.thoughtco.com/thmb/TRDolGdhiKx7SLOZIBPLtIK3ipc=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/lorax-597f13009abed50010c7da1d.jpg",
                PublishingYear = 1971,
                PublisherId = Guid.Parse("b2b63af9-18b0-48f4-9078-30836e6f54f7")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("30e10c71-f5a8-4065-ad1a-fa6439cac32e"),
                Title = "The Giving Tree",
                Author = "Shel Silverstein",
                Pages = 64,
                ISBN = "9780060256654",
                Price = 12.10,
                Image = "https://m.media-amazon.com/images/I/71wiGMKadmL._AC_UF1000,1000_QL80_.jpg",
                PublishingYear = 1964,
                PublisherId = Guid.Parse("b2b63af9-18b0-48f4-9078-30836e6f54f7")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("944d2a25-9509-45f1-ba05-e65095a8b5f8"),
                Title = "Stuart Little",
                Author = "E.B. White",
                Pages = 144,
                ISBN = "9780064400565",
                Price = 17,
                Image = "https://m.media-amazon.com/images/I/91a1ogh+5JL._AC_UF1000,1000_QL80_.jpg",
                PublishingYear = 1945,
                PublisherId = Guid.Parse("36bda0c2-9ea8-4c67-a86f-f81486343f12")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("91edf706-93ce-4695-81d2-e8db8212618b"),
                Title = "Madeline",
                Author = "Ludwig Bemelmans",
                Pages = 56,
                ISBN = "9780140564396",
                Price = 25,
                Image = "https://upload.wikimedia.org/wikipedia/en/1/19/Madeline-1939.jpg",
                PublishingYear = 1939,
                PublisherId = Guid.Parse("5d24ced7-7e83-4dae-9b60-d559d9d96bb0")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("16236379-7fd8-4f8e-b513-cef865dec7f7"),
                Title = "The Polar Express",
                Author = "Chris Van Allsburg",
                Pages = 32,
                ISBN = "9780395389492",
                Price = 20,
                Image = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1638557399i/420282.jpg",
                PublishingYear = 1985,
                PublisherId = Guid.Parse("5d24ced7-7e83-4dae-9b60-d559d9d96bb0")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("7ffbf854-8c14-4c02-afac-c3e30e3d7207"),
                Title = "Clifford the Big Red Dog",
                Author = "Norman Bridwell",
                Pages = 32,
                ISBN = "9780545215787",
                Price = 12.10,
                Image = "https://m.media-amazon.com/images/I/81TU2o5NYOL._AC_UF1000,1000_QL80_.jpg",
                PublishingYear = 1963,
                PublisherId = Guid.Parse("5d24ced7-7e83-4dae-9b60-d559d9d96bb0")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("e2ae75e8-7405-401f-945d-9539e98a50bd"),
                Title = "Brown Bear, Brown Bear, What Do You See?",
                Author = "Bill Martin Jr.",
                Pages = 28,
                ISBN = "9780805047905",
                Price = 15,
                Image = "https://m.media-amazon.com/images/I/81Ukrj-NTgL._AC_UF1000,1000_QL80_.jpg",
                PublishingYear = 1967,
                PublisherId = Guid.Parse("5d24ced7-7e83-4dae-9b60-d559d9d96bb0")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("efb48636-3c8c-44b2-9fab-160c3a172e9f"),
                Title = "Chicka Chicka Boom Boom",
                Author = "Bill Martin Jr. and John Archambault",
                Pages = 40,
                ISBN = "9781442450707",
                Price = 15.10,
                Image = "https://m.media-amazon.com/images/I/61rGNycNKbL._AC_UF1000,1000_QL80_.jpg",
                PublishingYear = 1989,
                PublisherId = Guid.Parse("5d24ced7-7e83-4dae-9b60-d559d9d96bb0")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("8c4a4908-7a5c-4364-ab4c-689deb411ccf"),
                Title = "Corduroy",
                Author = "Don Freeman",
                Pages = 32,
                ISBN = "9780140501735",
                Price = 25,
                Image = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1347517273i/231850.jpg",
                PublishingYear = 1968,
                PublisherId = Guid.Parse("bb40bb66-099d-40ff-8994-d5dc15e3d97d")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("c8d2119d-4cce-4ec9-98b1-66730bfdbd68"),
                Title = "If You Give a Mouse a Cookie",
                Author = "Laura Numeroff",
                Pages = 40,
                ISBN = "9780060245863",
                Price = 15,
                Image = "https://m.media-amazon.com/images/I/813csV5cPqL._AC_UF1000,1000_QL80_.jpg",
                PublishingYear = 1985,
                PublisherId = Guid.Parse("bb40bb66-099d-40ff-8994-d5dc15e3d97d")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("5b0325cc-f96c-408c-98de-caf886ec12ab"),
                Title = "The Rainbow Fish",
                Author = "Marcus Pfister",
                Pages = 24,
                ISBN = "9781558580091",
                Price = 12.10,
                Image = "https://m.media-amazon.com/images/I/91pdllYEUfL._AC_UF1000,1000_QL80_.jpg",
                PublishingYear = 1992,
                PublisherId = Guid.Parse("bb40bb66-099d-40ff-8994-d5dc15e3d97d")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("8237018b-97f0-4b42-8f10-4b545560f8be"),
                Title = "The Snowy Day",
                Author = "Ezra Jack Keats",
                Pages = 40,
                ISBN = "9780670867332",
                Price = 12,
                Image = "https://m.media-amazon.com/images/I/71Ku1Uk6VqL._AC_UF1000,1000_QL80_.jpg",
                PublishingYear = 1962,
                PublisherId = Guid.Parse("bb40bb66-099d-40ff-8994-d5dc15e3d97d")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("9e77be7c-c2c1-4a36-bb22-cc135935f7e4"),
                Title = "The Tale of Despereaux",
                Author = "Kate DiCamillo",
                Pages = 272,
                ISBN = "9780763680893",
                Price = 20,
                Image = "https://m.media-amazon.com/images/I/71G5VWfT-gL._AC_UF1000,1000_QL80_.jpg",
                PublishingYear = 2003,
                PublisherId = Guid.Parse("e04651b0-5913-4ee7-a691-cdb85933f3ee")
            };
            book = new Book()
            {
                Id = Guid.Parse("fd6a4340-079f-4890-a06f-367021cf840a"),
                Title = "The Paper Bag Princess",
                Author = "Robert Munsch",
                Pages = 32,
                ISBN = "9780920236161",
                Price = 15,
                Image = "https://m.media-amazon.com/images/I/71fZdpPbIML._AC_UF1000,1000_QL80_.jpg",
                PublishingYear = 1980,
                PublisherId = Guid.Parse("e04651b0-5913-4ee7-a691-cdb85933f3ee")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("41b480b1-02da-4c00-bc77-759879c25a99"),
                Title = "The Velveteen Rabbit",
                Author = "Margery Williams",
                Pages = 48,
                ISBN = "9780380002559",
                Price = 10.10,
                Image = "https://m.media-amazon.com/images/I/81+AkzSB5hL._AC_UF1000,1000_QL80_.jpg",
                PublishingYear = 1922,
                PublisherId = Guid.Parse("e04651b0-5913-4ee7-a691-cdb85933f3ee")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("a1efc311-abe5-4e9c-9220-345211e335f7"),
                Title = "The Tale of Jemima Puddle-Duck",
                Author = "Beatrix Potter",
                Pages = 64,
                ISBN = "9780723247784",
                Price = 12.10,
                Image = "https://m.media-amazon.com/images/I/51YliB2gTfL._AC_UF894,1000_QL80_.jpg",
                PublishingYear = 1908,
                PublisherId = Guid.Parse("e6dc8da9-4a57-4821-beb3-24117746b333")
            };
            books.Add(book);
            book = new Book()
            {
                Id = Guid.Parse("2d48162d-6e09-4648-8019-f584c51dd3c6"),
                Title = "Are You My Mother?",
                Author = "P.D. Eastman",
                Pages = 72,
                ISBN = "9780394800188",
                Price = 20,
                Image = "https://m.media-amazon.com/images/I/61GO+cnyq5L._AC_UF1000,1000_QL80_.jpg",
                PublishingYear = 1960,
                PublisherId = Guid.Parse("e6dc8da9-4a57-4821-beb3-24117746b333")
            };
            books.Add(book);
            return books;
        }

    }
}
