using System.Collections.Generic;
using Jirapi.Resources;

namespace Jirapi.Resources
{
    public class LocationAreaEncounter
    {
        public ApiResource<LocationArea> LocationArea { get; set; }
        public List<VersionEncounterDetail> VersionDetails { get; set; }
    }
}