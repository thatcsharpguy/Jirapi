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
        public async Task Pokemon_Is_Not_Null_By_Id()
        {
            PokeClient pc = new PokeClient();
            var pokemon = await pc.Get<Pokemon>(1);
            Assert.IsNotNull(pokemon);
        }

        [Test]
        public async Task Pokemon_Is_Not_Null_By_Name()
        {
            PokeClient pc = new PokeClient();
            var pokemon = await pc.Get<Pokemon>("bulbasaur");
            Assert.IsNotNull(pokemon);
        }

        [Test]
        public async Task PokemonSpecies_Is_Not_Null()
        {
            PokeClient pc = new PokeClient();
            var pokemon = await pc.Get<Pokemon>("bulbasaur");

            Assert.IsNotNull(pokemon);
            Assert.IsNotNull(pokemon.Species);
        }

        [Test]
        public async Task NamedApiResource_FillResource()
        {
            PokeClient pc = new PokeClient();
            var pokemon = await pc.Get<Pokemon>("bulbasaur");
            await pokemon.Species.FillResource();
            Assert.IsNotNull(pokemon.Species.Resource);
        }

        [Test]
        public async Task NamedApiResource_GetResource()
        {
            PokeClient pc = new PokeClient();
            var pokemon = await pc.Get<Pokemon>("bulbasaur");
            var species = await pokemon.Species.GetResource();
            Assert.IsNotNull(species);
        }

        [Test]
        public async Task Habitat_Is_Not_Null()
        {
            PokeClient pc = new PokeClient();
            var pokemon = await pc.Get<Pokemon>("bulbasaur");
            var species = await pokemon.Species.GetResource();
            await species.Habitat.FillResource();
            Assert.IsNotNull(species.Habitat.Resource);
        }

        [Test]
        public async Task Get_Item()
        {
            PokeClient pc = new PokeClient();
            var item = await pc.Get<Item>(3);
            Assert.IsNotNull(item);
        }

        [Test]
        public async Task Pokedex_Has_Descriptions()
        {
            PokeClient pc = new PokeClient();
            var dex = await pc.Get<Pokedex>(12);
            Assert.IsNotNull(dex.Descriptions);
            Assert.IsNotEmpty(dex.Descriptions);
        }

        [Test]
        public async Task Get_Jirachi_Pokemon()
        {
            PokeClient pc = new PokeClient();
            var dex = await pc.Get<Pokemon>("jirachi");
            Assert.IsNotNull(dex.Name);
        }

        [Test]
        public async Task Get_Caterpie_Pokemon()
        {
            PokeClient pc = new PokeClient();
            var pokemon = await pc.Get<Pokemon>(10);
            Assert.IsNotNull(pokemon.Name);
        }

        [Test]
        public async Task Get_Caterpie_Encounters_Classic()
        {
            PokeClient pc = new PokeClient();
            var pokemon = await pc.Get<Pokemon>(10);
            var encounters = await pc.GetListByUrlPart<LocationAreaEncounter>(pokemon.LocationAreaEncounters);
            Assert.IsNotEmpty(encounters);
        }

        [Test]
        public async Task Get_Caterpie_Encounters_Extension()
        {
            PokeClient pc = new PokeClient();
            var pokemon = await pc.Get<Pokemon>(10);
            var encounters = await pokemon.LocationAreaEncounters.GetResourceList<LocationAreaEncounter>();
            Assert.IsNotEmpty(encounters);
        }

    }
}
