using System.Collections.Generic;

namespace Jirapi.Resources
{
    public class EggGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Name> Names { get; set; }

        /// <summary>
        ///     A list of all Pokémon species that are members of this egg group.
        /// </summary>
        /// <value>The pokemon species.</value>
        /// [Newtonsoft.Json.JsonProperty("pokemon_species")]
        public List<NamedApiResource<PokemonSpecies>> PokemonSpecies { get; set; }
    }
}