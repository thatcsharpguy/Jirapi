using System.Collections.Generic;
using Jirapi.Resources;

namespace Jirapi.Resources
{
    public class ItemAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<NamedApiResource<Item>> Items { get; set; }

        public List<Name> Names { get; set; }

        public List<Description> Descriptions { get; set; }
    }
}