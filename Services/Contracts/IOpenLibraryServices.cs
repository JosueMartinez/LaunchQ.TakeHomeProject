using LaunchQ.TakeHomeProject.Models;

namespace LaunchQ.TakeHomeProject.Services.Contracts
{
    public interface IOpenLibraryServices
    {
        Task<List<Book>> GetBooksByAuthorAsync(string authorkey);
        Task<BookDetails> GetBookDetailsAsync(string workId);
    }
}
