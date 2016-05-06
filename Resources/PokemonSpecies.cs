using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jirapi.Resources
{
    public class PokemonSpecies
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        ///     The order in which species should be sorted. Based on National Dex order, except families are grouped together and
        ///     sorted by stage.
        /// </summary>
        /// <value>The order.</value>
        public int Order { get; set; }

        /// <summary>
        ///     The chance of this Pokémon being female, in eighths; or -1 for genderless.
        /// </summary>
        /// <value>The gender rate.</value>
        [JsonProperty("gender_rate")]
        public int GenderRate { get; set; }

        /// <summary>
        ///     The base capture rate; up to 255. The higher the number, the easier the catch.
        /// </summary>
        /// <value>The capture rate.</value>
        [JsonProperty("capture_rate")]
        public int CaptureRate { get; set; }

        /// <summary>
        ///     The happiness when caught by a normal Pokéball; up to 255. The higher the number, the happier the Pokémon.
        /// </summary>
        /// <value>The base happiness.</value>
        [JsonProperty("base_happiness")]
        public int BaseHappiness { get; set; }

        /// <summary>
        ///     Whether or not this is a baby Pokémon.
        /// </summary>
        [JsonProperty("is_baby")]
        public bool IsBaby { get; set; }

        /// <summary>
        ///     Initial hatch counter: one must walk 255 × (hatch_counter + 1) steps before this Pokémon's egg hatches, unless
        ///     utilizing bonuses like Flame Body's.
        /// </summary>
        [JsonProperty("hatch_counter")]
        public int HatchCounter { get; set; }

        /// <summary>
        ///     Whether or not this Pokémon can have different genders.
        /// </summary>
        [JsonProperty("has_gender_differences")]
        public bool HasGenderDifferences { get; set; }

        /// <summary>
        ///     Whether or not this Pokémon has multiple forms and can switch between them.
        /// </summary>
        [JsonProperty("forms_switchable")]
        public bool FormsSwitchable { get; set; }

        /// <summary>
        ///     The rate at which this Pokémon species gains levels
        /// </summary>
        [JsonProperty("growth_rate")]
        public NamedApiResource<GrowthRate> GrowthRate { get; set; }

        /// <summary>
        ///     A list of pokedexes and the indexes reserved within them for this Pokémon species.
        /// </summary>
        [JsonProperty("pokedex_numbers")]
        public List<PokemonSpeciesDexEntry> PokedexNumbers { get; set; }

        /// <summary>
        ///     A list of egg groups this Pokémon species is a member of.
        /// </summary>
        [JsonProperty("egg_groups")]
        public List<EggGroup> EggGroups { get; set; }

        /// <summary>
        ///     The color of this Pokémon for gimmicky Pokédex search.
        /// </summary>
        /// <value>The color.</value>
        public List<NamedApiResource<PokemonColor>> Color { get; set; }

        /// <summary>
        ///     The shape of this Pokémon for gimmicky Pokédex search.
        /// </summary>
        /// <value>The color.</value>
        public List<NamedApiResource<PokemonShape>> Shape { get; set; }

        /// <summary>
        ///     The Pokémon species that evolves into this pokemon_species.
        /// </summary>
        [JsonProperty("evolves_from_species")]
        public NamedApiResource<PokemonSpecies> EvolvesFromSpecies { get; set; }

        /// <summary>
        ///     The evolution chain this Pokémon species is a member of.
        /// </summary>
        [JsonProperty("evolution_chain")]
        public ApiResource<EvolutionChain> EvolutionChain { get; set; }

        /// <summary>
        ///     The generation this Pokémon species was introduced in.
        /// </summary>
        /// <value>The generation.</value>
        public NamedApiResource<Generation> Generation { get; set; }

        /// <summary>
        ///     The name of this Pokémon species listed in different languages.
        /// </summary>
        /// <value>The names.</value>
        public List<Name> Names { get; set; }

        /// <summary>
        ///     A list of encounters that can be had with this Pokémon species in pal park.
        /// </summary>
        /// <value>The pal park encounters.</value>
        [JsonProperty("pal_pak_encounters")]
        public List<PalParkEncounterArea> PalParkEncounters { get; set; }
    }
}