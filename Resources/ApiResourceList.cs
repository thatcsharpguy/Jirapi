using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jirapi.Resources
{
    public class ApiResourceList<T>
    {
        public int Count { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        public List<NamedApiResource<T>> Results { get; set; }
    }
}
