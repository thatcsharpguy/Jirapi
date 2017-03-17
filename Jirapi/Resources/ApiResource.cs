namespace Jirapi.Resources
{
    public class ApiResource<T>
    {
        public string URL { get; set; }

        public T Resource { get; set; }
    }
}