using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jirapi.Resources
{
    public class Effect
    {
        [JsonProperty("effect")]
        public string Effect1 { get; set; }

        public NamedApiResource<Language> Language { get; set; }

    }
}