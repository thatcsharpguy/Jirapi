using System.Collections.Generic;

namespace Jirapi.Resources
{
    public class Encounter
    {
        /// <summary>
        ///     The lowest level the Pokémon could be encountered at
        /// </summary>
        //[JsonProperty("min_level")]
        public int MinLevel { get; set; }

        /// <summary>
        ///     The highest level the Pokémon could be encountered at
        /// </summary>
        //[JsonProperty("max_level")]
        public int MaxLevel { get; set; }

        /// <summary>
        ///     A list of condition values that must be in effect for this encounter to occur
        /// </summary>
        //[JsonProperty("condition_values")]
        public List<NamedApiResource<EncounterConditionValue>> ConditionValues { get; set; }

        /// <summary>
        ///     Percent chance that this encounter will occur
        /// </summary>
        public int Chance { get; set; }

        /// <summary>
        ///     The method by which this encounter happens.
        /// </summary>
        public NamedApiResource<EncounterMethod> Method { get; set; }
    }
}