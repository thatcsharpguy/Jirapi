using System.Collections.Generic;
using Jirapi.Resources;

namespace Jirapi.Resources
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public NamedApiResource<Region> Region { get; set; }
        public List<Name> Names { get; set; }
        public List<GenerationGameIndex> GameIndices { get; set; }
        public ApiResource<LocationArea> Areas { get; set; }
    }
}