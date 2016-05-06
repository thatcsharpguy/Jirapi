namespace Jirapi.Resources
{
    public class VerboseEffect
    {
        /// <summary>
        ///     The localized effect text for an API resource in a specific language.
        /// </summary>
        public string Effect { get; set; }

        /// <summary>
        ///     The localized effect text in brief.
        /// </summary>
        //[JsonProperty("short_effect")]
        public string ShortEffect { get; set; }

        /// <summary>
        ///     The language this effect is in.
        /// </summary>
        public NamedApiResource<Language> Language { get; set; }
    }
}