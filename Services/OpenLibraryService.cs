using LaunchQ.TakeHomeProject.Models;
using LaunchQ.TakeHomeProject.Services.Contracts;
using Microsoft.Extensions.Options;
using System.Text.Json.Serialization;
using static System.Net.WebRequestMethods;

namespace LaunchQ.TakeHomeProject.Services
{
    public class OpenLibraryService : IOpenLibraryServices
    {
        private readonly HttpClient httpClient;
        private readonly string baseUrl;

        public OpenLibraryService(HttpClient _httpClient, IOptions<OpenLibrarySettings> settings)
        {
            httpClient = _httpClient;
            baseUrl = settings.Value.BaseUrl;
        }

        public async Task<List<Book>> GetBooksByAuthorAsync(string authorKey)
        {
            var response = await httpClient.GetFromJsonAsync<OpenLibraryWorksResponse>($"{baseUrl}authors/{authorKey}/works.json");
            if (response?.Entries == null)
                return new List<Book>();

            return response.Entries.Select(x => new Book
            {
                Title = x.Title,
                Key = x.Key
            }).ToList();
        }

        public async Task<BookDetails> GetBookDetailsAsync(string workId)
        {
            return await httpClient.GetFromJsonAsync<BookDetails>($"{baseUrl}works/{workId}.json");
        }
    }

    public class OpenLibraryWorksResponse
    {
        [JsonPropertyName("entries")]
        public List<WorkEntry> Entries { get; set; }

        public class WorkEntry
        {
            public string Title { get; set; }
            public string Key { get; set; }
        }
    }
}
