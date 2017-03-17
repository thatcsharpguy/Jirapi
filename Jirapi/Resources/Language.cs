using System.Collections.Generic;

namespace Jirapi.Resources
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Official { get; set; }
        public string Iso639 { get; set; }
        public string Iso3166 { get; set; }
        public List<Name> Names { get; set; }
    }
}