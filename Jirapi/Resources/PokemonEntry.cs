using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jirapi.Resources
{
    public class PokemonEntry
    {
        [JsonProperty("entry_number")]
        public int EntryNumber { get; set; }

        [JsonProperty("pokemon_species")]
        public NamedApiResource<PokemonSpecies> PokemonSpecies { get; set; }
    }
}