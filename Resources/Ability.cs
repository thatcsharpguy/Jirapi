using System.Collections.Generic;

namespace Jirapi.Resources
{
    public class Ability
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //[JsonProperty("is_main_series")]
        public bool IsMainSeries { get; set; }

        public NamedApiResource<Generation> Generation { get; set; }
        public List<Name> Names { get; set; }

        //[JsonProperty("effect_entries")]
        public List<VerboseEffect> EffectEntries { get; set; }

        //[JsonProperty("flavor_text_entries")]
        public List<VersionGroupFlavorText> FlavorTextEntries { get; set; }

        public List<AbilityPokemon> Pokemon { get; set; }
    }
}