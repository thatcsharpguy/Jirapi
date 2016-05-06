using Newtonsoft.Json;

namespace Jirapi.Resources
{
    public class PokemonForm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }

        [JsonProperty("form_order")]
        public int FormOrder { get; set; }

        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("is_battle_only")]
        public bool IsBattleOnly { get; set; }

        [JsonProperty("is_mega")]
        public bool IsMega { get; set; }

        [JsonProperty("form_name")]
        public string FormName { get; set; }

        public NamedApiResource<Pokemon> Pokemon { get; set; }
        public PokemonFormSprites Sprites { get; set; }

        [JsonProperty("version_group")]
        public NamedApiResource<VersionGroup> VersionGroup { get; set; }
    }
}