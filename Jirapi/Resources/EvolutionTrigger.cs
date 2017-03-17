using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jirapi.Resources
{
    public class EvolutionTrigger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Name> Names { get; set; }

        [JsonProperty("pokemon_species")]
        public List<NamedApiResource<PokemonSpecies>> PokemonSpecies { get; set; }
    }
}