using System.Collections.Generic;
using Newtonsoft.Json;

namespace Jirapi.Resources
{
    public class Berry
    {
        public int Id { get; set; }
        public string Name { get; set; }


        [JsonProperty("growth_time")]
        public int GrowthTime { get; set; }

        [JsonProperty("max_harvest")]
        public int MaxHarvest { get; set; }

        [JsonProperty("natural_gift_power")]
        public int NaturalGiftPower { get; set; }

        public int Size { get; set; }
        public int Smoothness { get; set; }

        [JsonProperty("soil_dryness")]
        public int SoilDryness { get; set; }

        public NamedApiResource<BerryFirmness> Firmness { get; set; }
        public List<FlavorBerryMap> Flavors { get; set; }
        public NamedApiResource<Item> Item { get; set; }

        [JsonProperty("natural_gift_types")]
        public NamedApiResource<Type> NaturalGiftType { get; set; }
    }
}