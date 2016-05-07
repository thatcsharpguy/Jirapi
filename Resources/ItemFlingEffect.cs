using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jirapi.Resources
{
    public class ItemFlingEffect
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonProperty("effect_entries")]
        public List<Effect> EffectEntries { get; set; }
        public List<NamedApiResource<Item>> Items { get; set; }
    }
}