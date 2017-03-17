namespace Jirapi.Resources
{
    public class EvolutionChain
    {
        public int Id { get; set; }
        public NamedApiResource<Item> BabyTriggerItem { get; set; }
        public ChainLink Chain { get; set; }
    }
}