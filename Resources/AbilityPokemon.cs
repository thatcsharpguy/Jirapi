using Newtonsoft.Json;

namespace Jirapi.Resources
{
    public class AbilityPokemon
    {
        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }

        public int Slot { get; set; }
        public NamedApiResource<Pokemon> Pokemon { get; set; }
    }
}