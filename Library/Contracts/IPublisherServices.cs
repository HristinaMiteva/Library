using Library.Models.PublisherViewModels;

namespace Library.Contracts
{
    public interface IPublisherServices
    {
        Task<IEnumerable<PublishersViewModel>> GetAllAsync();
        Task AddPublisherAsync(AddPublisherViewModel model);
    }
}
