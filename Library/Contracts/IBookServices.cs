using Library.Data.Models;
using Library.Models.BookViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;

namespace Library.Contracts
{
    public interface IBookServices
    {
        Task<IEnumerable<BooksViewModel>> GetAllAsync();
        SelectList AddBookAsync();
        Task AddBookAsync(AddBookViewModel model);
        Task ReadBookAsync(Guid id, User user);
        Task<IEnumerable<BooksViewModel>> BookReadAsync(User user);
        Task FavoriteBookAsync(Guid id, User user);
        Task<IEnumerable<BooksViewModel>> BookFavoriteAsync(User user);
        Task DeleteBookAsync(Guid id);
        Task RemoveFromFavoiretesAsync(Guid bookId, User user);
        Task<IEnumerable<BooksViewModel>> SearchedBooksAsync(string bookName);
        Task<IEnumerable<BooksViewModel>> GetAllQuizesAsync();
        Task<IEnumerable<BooksViewModel>> FindBooksByAuthorAsync(string author);
        Task<IEnumerable<BooksViewModel>> FindBooksByPublishingHouseAsync(string publishingHouse);
        Task<IEnumerable<BooksViewModel>> FindBooksByPriceRangeAsync(int minPrice, int maxPrice);

    }
}
