using System.Collections.Generic;
using Jirapi.Resources;

namespace Jirapi.Resources
{
    public class EncounterMethodRate
    {
        public EncounterMethod EncounterMethod { get; set; }
        public List<EncounterVersionDetails> VersionDetails { get; set; }
    }
}