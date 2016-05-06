using Jirapi.Resources;

namespace Jirapi.Resources
{
    public class PokemonAbility
    {
        //[JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }

        public int Slot { get; set; }
        public NamedApiResource<Ability> Ability { get; set; }
    }
}