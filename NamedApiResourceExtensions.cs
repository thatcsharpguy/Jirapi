using System.Threading.Tasks;
using Jirapi.Resources;

namespace Jirapi
{
    public static class NamedApiResourceExtensions
    {
        public static async Task GetResource<T>(this NamedApiResource<T> named, PokeClient client = null)
        {
            var cli = client ?? new PokeClient();
            named.Resource = await cli.GetByUrl<T>(named.URL.TrimEnd('/'));
        }
    }
}