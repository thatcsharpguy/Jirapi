namespace Jirapi.Resources
{
    public class EncounterVersionDetails
    {
        public int Rate { get; set; }
        public NamedApiResource<Version> Version { get; set; }
    }
}