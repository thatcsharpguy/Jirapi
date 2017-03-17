using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jirapi
{
    public static class StringApiResourceExtensions
    {

        public static async Task<List<T>> GetResourceList<T>(this string urlPart, PokeClient client = null)
        {
            var cli = client ?? new PokeClient();
            return await cli.GetListByUrlPart<T>(urlPart);
        }
    }
}
