using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jirapi.Resources
{
    public class PokemonColor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Name> Names { get; set; }

        /// <summary>
        ///     A list of the Pokémon species that have this color.
        /// </summary>
        /// <value>The pokemon species.</value>
        [JsonProperty("pokemon_species")]
        public List<NamedApiResource<PokemonSpecies>> PokemonSpecies { get; set; }
    }
}