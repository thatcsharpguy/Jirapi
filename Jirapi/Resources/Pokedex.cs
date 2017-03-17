using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jirapi.Resources
{
    public class Pokedex
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        ///     Whether or not this Pokédex originated in the main series of the video games.
        /// </summary>
        [JsonProperty("is_main_series")]
        public bool IsMainSeries { get; set; }

        /// <summary>
        ///     The description of this Pokédex listed in different languages.
        /// </summary>
        /// <value>The description.</value>
        public List<Description> Descriptions { get; set; }

        /// <summary>
        ///     The name of this Pokédex listed in different languages.
        /// </summary>
        /// <value>The names.</value>
        public List<Name> Names { get; set; }

        /// <summary>
        ///     A list of pokemon catalogued in this Pokédex and their indexes.
        /// </summary>
        /// <value>The pokemon entries.</value>
        [JsonProperty("pokemon_entries")]
        public List<PokemonEntry> PokemonEntries { get; set; }

        public NamedApiResource<Region> Region { get; set; }

        [JsonProperty("version_groups")]
        public List<NamedApiResource<VersionGroup>> VersionGroups { get; set; }
    }
}