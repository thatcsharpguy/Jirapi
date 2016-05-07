using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Jirapi.Resources
{
    public class PokemonSprites
    {
        [JsonProperty("back_female")]
        public string BackFemale { get; set; }

        [JsonProperty("back_shiny_female")]
        public string BackShinyFemale { get; set; }

        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("front_female")]
        public string FrontFemale { get; set; }

        [JsonProperty("front_shiny_female")]
        public string FrontShinyFemale { get; set; }

        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }
    }
}
