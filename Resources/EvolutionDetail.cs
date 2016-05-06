using Jirapi.Resources;

namespace Jirapi.Resources
{
    public class EvolutionDetail
    {
        public NamedApiResource<Item> Item { get; set; }
        public NamedApiResource<EvolutionTrigger> Trigger { get; set; }
        public NamedApiResource<Gender> Gender { get; set; }

        //[JsonProperty("held_item")]
        public NamedApiResource<Item> HeldItem { get; set; }

        //[JsonProperty("known_move")]
        public NamedApiResource<Move> KnownMove { get; set; }

        //[JsonProperty("known_move_type")]
        public NamedApiResource<Type> KnownMoveType { get; set; }

        public NamedApiResource<Location> Location { get; set; }

        //[JsonProperty("min_level")]
        public int MinLevel { get; set; }

        //[JsonProperty("min_happiness")]
        public int MinHappiness { get; set; }

        //[JsonProperty("min_beauty")]
        public int MinBeauty { get; set; }

        //[JsonProperty("min_affection")]
        public int MinAffection { get; set; }

        //[JsonProperty("needs_overworld_rain")]
        public bool NeedsOverworldRain { get; set; }

        //[JsonProperty("party_species")]
        public NamedApiResource<PokemonSpecies> PartySpecies { get; set; }

        //[JsonProperty("relative_physical_stats")]
        public int RelativePhysicalStats { get; set; }

        //[JsonProperty("time_of_day")]
        public string TimeOfDay { get; set; }

        //[JsonProperty("trade_species")]
        public NamedApiResource<PokemonSpecies> TradeSpecies { get; set; }

        //[JsonProperty("turn_upside_down")]
        public bool TurnUpsideDown { get; set; }
    }
}