using LaunchQ.TakeHomeProject.Models;

namespace LaunchQ.TakeHomeProject.Services.Contracts
{
    public interface IFavoritesService
    {
        List<Book> GetFavorites();
        void AddToFavorites(Book book);
        void RemoveFromFavorites(Book book);
    }
}
