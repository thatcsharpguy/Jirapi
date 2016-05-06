using System.Collections.Generic;

namespace Jirapi.Resources
{
    public class PokemonEntry
    {
        //[JsonProperty("entry_number")]
        public int EntryNumber { get; set; }

        //[JsonProperty("pokemon_species")]
        public List<NamedApiResource<PokemonSpecies>> PokemonSpecies { get; set; }

        public NamedApiResource<Region> Region { get; set; }

        //[JsonProperty("version_group")]
        public NamedApiResource<VersionGroup> VersionGroup { get; set; }
    }
}