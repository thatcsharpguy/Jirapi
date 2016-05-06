using Jirapi.Resources;

namespace Jirapi.Resources
{
    public class Nature
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public NamedApiResource<Stat> DecreasedStat { get; set; }
        public NamedApiResource<Stat> IncreasedStat { get; set; }
        public NamedApiResource<BerryFlavor> HatesFlavor { get; set; }
        public NamedApiResource<BerryFlavor> LikesFlavor { get; set; }
    }
}