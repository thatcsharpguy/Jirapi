using Newtonsoft.Json;

namespace Jirapi.Resources
{
    public class VersionGroupFlavorText
    {
        /// <summary>
        ///     The localized name for an API resource in a specific language.
        /// </summary>
        /// <value>The text.</value>
        public string Text { get; set; }

        /// <summary>
        ///     The language this name is in.
        /// </summary>
        public NamedApiResource<Language> Language { get; set; }


        [JsonProperty("version_group")]
        public NamedApiResource<VersionGroup> VersionGroup { get; set; }
    }
}