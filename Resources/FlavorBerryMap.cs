namespace Jirapi.Resources
{
    public class FlavorBerryMap
    {
        public int Potency { get; set; }
        public NamedApiResource<Berry> Berry { get; set; }
    }
}