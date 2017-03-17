using System.Collections.Generic;

namespace Jirapi.Resources
{
    public class BerryFlavor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<FlavorBerryMap> Berries { get; set; }
    }
}