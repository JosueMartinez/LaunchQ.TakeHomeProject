using System.Text.Json.Serialization;

namespace LaunchQ.TakeHomeProject.Models
{
    public class BookDetails
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public object Description { get; set; }

        [JsonPropertyName("subjects")]
        public List<string> Subjects { get; set; }
    }
}
