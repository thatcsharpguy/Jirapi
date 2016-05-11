using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using Jirapi.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using TestContext = Microsoft.VisualStudio.TestTools.UnitTesting.TestContext;

namespace Jirapi.Test
{
    /// <summary>
    /// Summary description for RealDataTests
    /// </summary>

    [TestFixture]
    public class TrueApiTests
    {
        [Test]
        public async Task Get_Pokedex_Resource_List_Count()
        {
            PokeClient pc = new PokeClient();
            var dex = await pc.GetResourceList<Pokedex>(0, 5);
            Assert.AreEqual(5, dex.Results.Count);
        }

        [Test]
        public async Task Get_Pokedex_Resource_Previous_Next_Are_Null()
        {
            PokeClient pc = new PokeClient();
            var dex = await pc.GetResourceList<Pokedex>(0, 60);
            Assert.IsNull(dex.Next);
            Assert.IsNull(dex.Previous);
        }

    }
}
