using System.Collections.Generic;
using Jirapi.Resources;

namespace Jirapi.Resources
{
    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //[JsonProperty("pokemon_species_details")]
        public List<PokemonSpeciesGender> PokemonSpeciesDetails { get; set; }

        //[JsonProperty("required_for_evolution")]
        public List<NamedApiResource<PokemonSpecies>> RequiredForEvolution { get; set; }
    }
}