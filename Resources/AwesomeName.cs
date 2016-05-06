using Jirapi.Resources;

namespace Jirapi.Resources
{
    public class AwesomeName
    {
        /// <summary>
        ///     The localized "scientific" name for an API resource in a specific language.
        /// </summary>
        /// <value>The awesome name1.</value>
        //[JsonProperty("awesome_name")]
        public string AwesomeName1 { get; set; }

        /// <summary>
        ///     The language this "scientific" name is in.
        /// </summary>
        /// <value>The language.</value>
        public NamedApiResource<Language> Language { get; set; }
    }
}