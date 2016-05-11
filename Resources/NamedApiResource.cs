namespace Jirapi.Resources
{
    public class NamedApiResource<T> : ApiResource<T>
    {
        public string Name { get; set; }
    }
}