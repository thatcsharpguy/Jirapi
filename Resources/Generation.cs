using System.Collections.Generic;

namespace Jirapi.Resources
{
    public class Generation
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public List<NamedApiResource<Ability>> Abilities { get; set; }
        public List<Name> Names { get; set; }

        //[JsonProperty("main_region")]
        public NamedApiResource<Region> MainRegion { get; set; }

        public List<NamedApiResource<Move>> Moves { get; set; }
    }
}