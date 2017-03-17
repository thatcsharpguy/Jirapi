namespace Jirapi.Resources
{
    public class PokemonType
    {
        public int Slot { get; set; }
        public NamedApiResource<Type> Type { get; set; }
    }
}