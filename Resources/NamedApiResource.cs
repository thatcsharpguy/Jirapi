namespace Jirapi.Resources
{
    public class NamedApiResource<T>
    {
        public string Name { get; set; }
        public string URL { get; set; }

        public T Resource { get; set; }
    }
}