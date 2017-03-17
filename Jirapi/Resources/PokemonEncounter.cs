using System.Collections.Generic;

namespace Jirapi.Resources
{
    public class PokemonEncounter
    {
        public NamedApiResource<Pokemon> Pokemon { get; set; }

        public List<VersionEncounterDetail> VersionDetails { get; set; }
    }
}