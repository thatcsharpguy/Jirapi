using Jirapi.Resources;

namespace Jirapi.Resources
{
    public class TypePokemon
    {
        public int Slot { get; set; }
        public NamedApiResource<Pokemon> Pokemon { get; set; }
    }
}