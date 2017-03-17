using System.Collections.Generic;

namespace Jirapi.Resources
{
    public class ItemCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<NamedApiResource<Item>> Items { get; set; }
        public List<Name> Names { get; set; }
        public NamedApiResource<ItemPocket> Pocket { get; set; }
    }
}