using Library.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data.Configuration
{
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasData(CreatePublisher());
        }

        private List<Publisher> CreatePublisher()
        {
            List<Publisher> publishers = new List<Publisher>();
            Publisher publisher = new Publisher()
            {
                Id = Guid.Parse("5d2db36e-b584-4abf-a093-5b9ffe196486"),
                Name = "Albert Whitman"
            };
            publishers.Add(publisher);

            publisher = new Publisher()
            {
                Id=Guid.Parse("ea3480ae-657b-4bcf-ac44-8e45081b58e6"),
                Name= "Holiday House"
            };
            publishers.Add(publisher);

            publisher = new Publisher()
            {
                Id = Guid.Parse("b2b63af9-18b0-48f4-9078-30836e6f54f7"),
                Name = "Candlewick Press"
            };
            publishers.Add(publisher);
            publisher = new Publisher()
            {
                Id = Guid.Parse("931e6d94-1fc5-4af1-a722-f05bde8c64f9"),
                Name = "August House"
            };
            publishers.Add(publisher);
            publisher = new Publisher()
            {
                Id = Guid.Parse("36bda0c2-9ea8-4c67-a86f-f81486343f12"),
                Name = "Arbordale Publishing"
            };
            publishers.Add(publisher);
            publisher = new Publisher()
            {
                Id = Guid.Parse("5d24ced7-7e83-4dae-9b60-d559d9d96bb0"),
                Name = "Chronicle Books"
            };
            publishers.Add(publisher);
            publisher = new Publisher()
            {
                Id = Guid.Parse("1ec7709f-f106-441d-b0d8-dbdc5d06971d"),
                Name = "Free Spirit Publishing"
            };
            publishers.Add(publisher);
            publisher = new Publisher()
            {
                Id = Guid.Parse("bb40bb66-099d-40ff-8994-d5dc15e3d97d"),
                Name = "Kids Can Press"
            };
            publishers.Add(publisher);
            publisher = new Publisher()
            {
                Id = Guid.Parse("e6dc8da9-4a57-4821-beb3-24117746b333"),
                Name = "Quirk Books"
            };
            publishers.Add(publisher);
            publisher = new Publisher()
            {
                Id = Guid.Parse("e04651b0-5913-4ee7-a691-cdb85933f3ee"),
                Name = "Flying Eye Books"
            };
            publishers.Add(publisher);

            return publishers;
        }
    }
}

