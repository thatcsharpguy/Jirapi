using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jirapi.Resources
{
    public class PalParkEncounterArea
    {
        /// <summary>
        ///     The base score given to the player when the referenced Pokémon is caught during a pal park run.
        /// </summary>
        /// <value>The base score.</value>
        [JsonProperty("base_score")]
        public int BaseScore { get; set; }

        /// <summary>
        ///     The base rate for encountering the referenced Pokémon in this pal park area.
        /// </summary>
        /// <value>The rate.</value>
        public int Rate { get; set; }

        /// <summary>
        ///     The pal park area where this encounter happens.
        /// </summary>
        /// <value>The area.</value>
        public NamedApiResource<PalParkArea> Area { get; set; }

        [JsonProperty("flavor_text_entries")]
        public List<PokemonSpeciesFlavorText> FlavorTextEntries { get; set; }

        [JsonProperty("form_descriptions")]
        public List<Description> FormDescriptions { get; set; }

        public Genus Genera { get; set; }

        public List<NamedApiResource<Pokemon>> Varieties { get; set; }
    }
}