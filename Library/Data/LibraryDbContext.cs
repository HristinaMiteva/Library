using Library.Data.Configuration;
using Library.Data.Models;
using Library.Models.Account;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class LibraryDbContext : IdentityDbContext<User>
    {
        private bool seedDB;
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options, bool seedDB=true)
            : base(options)
        {
            if (this.Database.IsRelational())
            {
                this.Database.Migrate();
            }
            else
            {
                this.Database.EnsureCreated();
            }
            this.seedDB = seedDB;
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<UserBook> UserBooks { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Question> Questions { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            if (seedDB)
            {
                builder.ApplyConfiguration(new PublisherConfiguration());
                builder.ApplyConfiguration(new BookConfiguration());
            }
           
            builder.Entity<UserBook>()
                .HasKey(x => new { x.UserId, x.BookId });

            builder.Entity<Favorite>()
                .HasKey(x => new { x.UserId, x.BookId });
            base.OnModelCreating(builder);

            builder.Entity<Question>().Ignore(q => q.Options);
            
        }

    }
}