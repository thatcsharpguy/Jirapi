using System.Collections.Generic;

namespace Jirapi.Resources
{
    public class ChainLink
    {
        //[JsonProperty("is_baby")]
        public bool IsBaby { get; set; }

        public NamedApiResource<PokemonSpecies> Species { get; set; }

        //[JsonProperty("evolution_details")]
        public EvolutionDetail EvolutionDetails { get; set; }

        //[JsonProperty("evolves_to")]
        public List<ChainLink> EvolvesTo { get; set; }
    }
}