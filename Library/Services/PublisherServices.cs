using Library.Contracts;
using Library.Data;
using Library.Models.PublisherViewModels;
using Microsoft.EntityFrameworkCore;
using Library.Data.Models;

namespace Library.Services
{
    public class PublisherServices:IPublisherServices

    {
        private readonly ApplicationDbContext context;

        public PublisherServices(ApplicationDbContext context)
        {
            this.context = context;
        }



        public async Task<IEnumerable<PublishersViewModel>> GetAllAsync()
        {
            var entities = await context.Publishers.ToListAsync();
            return entities
                .Select(b => new PublishersViewModel
                {
                    Id = b.Id,
                    Name = b.Name,
                    City = b.City
                });

        }
        public async Task AddPublisherAsync(AddPublisherViewModel model)
        {
            Publisher publisher = new Publisher()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                City = model.City
            };
            await this.context.Publishers.AddAsync(publisher);
            await context.SaveChangesAsync();

        }

        public async Task DeletePublisherAsync(Guid id)
        {
            var model = await this.context.Publishers
                .FirstOrDefaultAsync(x => x.Id == id);

            if (model != null)
            {
                context.Publishers.Remove(model);
                await context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}
