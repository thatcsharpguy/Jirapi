using System.Threading.Tasks;
using Jirapi.Resources;

namespace Jirapi
{
    public static class NamedApiResourceExtensions
    {
        public static async Task FillResource<T>(this NamedApiResource<T> named, PokeClient client = null)
        {
            var cli = client ?? new PokeClient();
            named.Resource = await cli.GetByUrl<T>(named.URL);
        }
        public static async Task<T> GetResource<T>(this NamedApiResource<T> named, PokeClient client = null)
        {
            var cli = client ?? new PokeClient();
            return await cli.GetByUrl<T>(named.URL);
        }
        public static async Task FillResource<T>(this ApiResource<T> named, PokeClient client = null)
        {
            var cli = client ?? new PokeClient();
            named.Resource = await cli.GetByUrl<T>(named.URL);
        }
        public static async Task<T> GetResource<T>(this ApiResource<T> named, PokeClient client = null)
        {
            var cli = client ?? new PokeClient();
            return await cli.GetByUrl<T>(named.URL);
        }
    }
}