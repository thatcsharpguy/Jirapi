using Newtonsoft.Json;

namespace Jirapi.Resources
{
    public class PokemonFormSprites
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }
    }
}