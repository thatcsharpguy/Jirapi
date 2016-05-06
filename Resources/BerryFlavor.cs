using System.Collections.Generic;
using Jirapi.Resources;

namespace Jirapi.Resources
{
    public class BerryFlavor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<FlavorBerryMap> Berries { get; set; }
    }
}