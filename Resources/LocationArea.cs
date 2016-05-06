using System.Collections.Generic;
using Jirapi.Resources;

namespace Jirapi.Resources
{
    public class LocationArea
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //[JsonProperty("game_index")]
        public int GameIndex { get; set; }

        //[JsonProperty("encounter_method_rates")]
        public List<EncounterMethodRate> EncounterMethodRates { get; set; }

        public NamedApiResource<Region> Location { get; set; }
        public List<Name> Names { get; set; }

        //[JsonProperty("pokemon_encounters")]
        public List<PokemonEncounter> PokemonEncounters { get; set; }
    }
}