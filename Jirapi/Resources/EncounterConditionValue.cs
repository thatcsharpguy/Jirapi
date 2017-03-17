using System.Collections.Generic;

namespace Jirapi.Resources
{
    public class EncounterConditionValue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<NamedApiResource<EncounterCondition>> Condition { get; set; }
        public List<Name> Names { get; set; }
    }
}