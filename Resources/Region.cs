namespace Jirapi.Resources
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public NamedApiResource<Location> Locations { get; set; }
    }
}