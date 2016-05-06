namespace Jirapi.Resources
{
    public class GenerationGameIndex
    {
        //[JsonProperty("game_index")]
        public int GameIndex { get; set; }

        public NamedApiResource<Generation> Generation { get; set; }
    }
}