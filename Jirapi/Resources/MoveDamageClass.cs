using System.Collections.Generic;

namespace Jirapi.Resources
{
    public class MoveDamageClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Description> Descriptions { get; set; }
        public List<NamedApiResource<Move>> Moves { get; set; }
        public List<Name> Names { get; set; }
    }
}