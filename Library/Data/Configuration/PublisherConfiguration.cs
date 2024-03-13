using Library.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data.Configuration
{
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            throw new NotImplementedException();
        }

       /* private List<Publisher> CreatePublisher()
        {
            List<Publisher> publishers = new List<Publisher>();
            Publisher publisher = new Publisher()
            {

            };

             publishers.Add(publisher);

            publisher = new Publisher()
            {

            };
       */
        
    }
}
