using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jirapi.Resources
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonProperty("base_experience")]
        public int BaseExperience { get; set; }

        public int Height { get; set; }


        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        public int Order { get; set; }
        public int Weight { get; set; }
        public List<PokemonAbility> Abilities { get; set; }
        public List<NamedApiResource<PokemonForm>> Forms { get; set; }


        [JsonProperty("game_indices")]
        public List<VersionGameIndex> GameIndices { get; set; }


        [JsonProperty("held_items")]
        public List<NamedApiResource<Item>> HeldItems { get; set; }

        // Issue with recent deployment of Pokéapi
        //[JsonProperty("location_area_encounters")]
        //public List<LocationAreaEncounter> LocationAreaEncounters { get; set; }

        public List<NamedApiResource<Move>> Moves { get; set; }
        public NamedApiResource<PokemonSpecies> Species { get; set; }
        public PokemonSprites Sprites { get; set; }
        public List<NamedApiResource<Stat>> Stats { get; set; }
        public List<PokemonType> Types { get; set; }
    }


}