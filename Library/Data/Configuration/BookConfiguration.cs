using Library.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            throw new NotImplementedException();
        }
        /* private List<Book>CreateBooks()
         {
             List<Book> books = new List<Book>();
             Book book = new Book()
             {

             };

             books.Add(book);

             book = new Book()
             {

             };

         }
     }*/
    }
}
