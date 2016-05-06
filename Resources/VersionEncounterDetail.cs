namespace Jirapi.Resources
{
    public class VersionEncounterDetail
    {
        public NamedApiResource<Version> Version { get; set; }

        //[JsonProperty("max_chance")]
        public int MaxChance { get; set; }

        //[JsonProperty("encounter_details")]
        public Encounter EncounterDetails { get; set; }
    }
}