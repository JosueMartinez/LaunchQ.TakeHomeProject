using LaunchQ.TakeHomeProject.Models;
using LaunchQ.TakeHomeProject.Services.Contracts;

namespace LaunchQ.TakeHomeProject.Services
{
    public class FavoritesService : IFavoritesService
    {
        private readonly List<Book> favoriteBooks = new List<Book>();

        public void AddToFavorites(Book book)
        {
            if (!favoriteBooks.Any(b => b.Title == book.Title))
                favoriteBooks.Add(book);
        }

        public void RemoveFromFavorites(Book book)
        {
            var bookToRemove = favoriteBooks.FirstOrDefault(b => b.Title == book.Title);
            if (bookToRemove != null)
                favoriteBooks.Remove(bookToRemove);
        }

        public List<Book> GetFavorites()
        {
            return favoriteBooks;
        }
    }
}
