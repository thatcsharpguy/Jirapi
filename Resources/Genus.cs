using Newtonsoft.Json;

namespace Jirapi.Resources
{
    public class Genus
    {
        [JsonProperty("genus")]
        public string Genus1 { get; set; }
        public NamedApiResource<Language> Language { get; set; }
    }
}