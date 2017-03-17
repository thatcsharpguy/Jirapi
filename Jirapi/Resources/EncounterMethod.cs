using System.Collections.Generic;

namespace Jirapi.Resources
{
    public class EncounterMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public List<Name> Names { get; set; }
    }
}