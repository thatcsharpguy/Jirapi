using System.Collections.Generic;
using Jirapi.Resources;

namespace Jirapi.Resources
{
    public class GrowthRate
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        ///     The formula used to calculate the rate at which the Pokémon species gains level
        /// </summary>
        public string Formula { get; set; }

        /// <summary>
        ///     The descriptions of this characteristic listed in different languages.
        /// </summary>
        /// <value>The descriptions.</value>
        public List<Description> Descriptions { get; set; }

        /// <summary>
        ///     A list of levels and the amount of experienced needed to atain them based on this growth rate.
        /// </summary>
        public List<GrowthRateExperienceLevel> Levels { get; set; }

        /// <summary>
        ///     A list of Pokémon species that gain levels at this growth rate.
        /// </summary>
        /// <value>The pokemon species.</value>
        /// //[JsonProperty("pokemon_species")]
        public List<NamedApiResource<PokemonSpecies>> PokemonSpecies { get; set; }
    }
}