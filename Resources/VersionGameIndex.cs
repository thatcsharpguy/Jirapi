using Newtonsoft.Json;

namespace Jirapi.Resources
{
    public class VersionGameIndex
    {
        [JsonProperty("game_index")]
        public int GameIndex { get; set; }

        public NamedApiResource<Version> Version { get; set; }
    }
}