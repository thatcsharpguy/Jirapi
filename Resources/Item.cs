using System.Collections.Generic;

namespace Jirapi.Resources
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }

        //[JsonProperty("fling_power")]
        public int FlingPower { get; set; }

        //[JsonProperty("fling_effect")]
        public ItemFlingEffect FlingEffect { get; set; }

        public List<NamedApiResource<ItemAttribute>> Attributes { get; set; }
        public ItemCategory Category { get; set; }

        //[JsonProperty("effect_entries")]
        public List<VerboseEffect> EffectEntries { get; set; }

        //[JsonProperty("flavor_text_entries")]
        public List<VersionGroupFlavorText> FlavorTextEntries { get; set; }

        //[JsonProperty("game_indices")]
        public List<GenerationGameIndex> GameIndices { get; set; }

        public List<Name> Names { get; set; }
        public ItemSprites Sprites { get; set; }

        //[JsonProperty("held_by_pokemon")]
        public List<NamedApiResource<Pokemon>> HeldByPokemon { get; set; }

        //[JsonProperty("baby_trigger_for")]
        public List<ApiResource<EvolutionChain>> BabyTriggerFor { get; set; }
    }
}