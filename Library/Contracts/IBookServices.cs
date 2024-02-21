using Library.Data.Models;
using Library.Models.BookViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.Contracts
{
    public interface IBookServices
    {
        Task<IEnumerable<BooksViewModel>> GetAllAsync();
        SelectList AddBookAsync();
        Task AddBookAsync(AddBookViewModel model);
        Task ReadBookAsync(Guid id, User user);
        Task<IEnumerable<BooksViewModel>> BookReadAsync(User user);
    }
}
