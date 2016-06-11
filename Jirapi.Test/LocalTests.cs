using System;
using System.Threading.Tasks;
using Flurl.Http.Testing;
using Jirapi.Resources;
using NUnit.Framework;

namespace Jirapi.Test
{
    [TestFixture]
    public class LocalTests
    {
        private HttpTest _flurlTest;

        [SetUp]
        public void CreateHttpTest()
        {
            _flurlTest = new HttpTest();
        }

        [TearDown]
        public void DisposeHttpTest()
        {
            _flurlTest.Dispose();
        }

        [Test]
        public async Task Pokemon_Is_Not_Null_By_Id()
        {
            _flurlTest.RespondWith(Responses.Bulbasaur);
            PokeClient pc = new PokeClient();
            var pokemon = await pc.Get<Pokemon>(1);
            Assert.IsNotNull(pokemon);
        }

        [Test]
        public async Task Pokemon_Is_Not_Null_By_Name()
        {
            _flurlTest.RespondWith(Responses.Bulbasaur);
            PokeClient pc = new PokeClient();
            var pokemon = await pc.Get<Pokemon>("bulbasaur");
            Assert.IsNotNull(pokemon);
        }

        [Test]
        public async Task PokemonSpecies_Is_Not_Null()
        {
            _flurlTest.RespondWith(Responses.Bulbasaur);
            PokeClient pc = new PokeClient();
            var pokemon = await pc.Get<Pokemon>("bulbasaur");

            Assert.IsNotNull(pokemon);
            Assert.IsNotNull(pokemon.Species);
        }

        [Test]
        public async Task NamedApiResource_FillResource()
        {
            _flurlTest
                .RespondWith(Responses.Bulbasaur)
                .RespondWith(Responses.BulbasaurSpecies);
            PokeClient pc = new PokeClient();
            var pokemon = await pc.Get<Pokemon>("bulbasaur");
            await pokemon.Species.FillResource();
            Assert.IsNotNull(pokemon.Species.Resource);
        }

        [Test]
        public async Task NamedApiResource_GetResource()
        {
            _flurlTest
                .RespondWith(Responses.Bulbasaur)
                .RespondWith(Responses.BulbasaurSpecies);
            PokeClient pc = new PokeClient();
            var pokemon = await pc.Get<Pokemon>("bulbasaur");
            var species = await pokemon.Species.GetResource();
            Assert.IsNotNull(species);
        }

        [Test]
        public async Task Habitat_Is_Not_Null()
        {
            _flurlTest
                .RespondWith(Responses.Bulbasaur)
                .RespondWith(Responses.BulbasaurSpecies)
                .RespondWith(Responses.BulbasaurHabitat);
            PokeClient pc = new PokeClient();
            var pokemon = await pc.Get<Pokemon>("bulbasaur");
            var species = await pokemon.Species.GetResource();
            await species.Habitat.FillResource();
            Assert.IsNotNull(species.Habitat.Resource);
        }

        [Test]
        public async Task Get_Item()
        {
            _flurlTest
                .RespondWith(Responses.GreatBall);
            PokeClient pc = new PokeClient();
            var item = await pc.Get<Item>(3);
            Assert.IsNotNull(item);
        }

        [Test]
        public async Task Pokedex_Has_Descriptions()
        {
            _flurlTest
                .RespondWith(Responses.KalosCentralPokedex);
            PokeClient pc = new PokeClient();
            var dex = await pc.Get<Pokedex>(12);
            Assert.IsNotNull(dex.Descriptions);
            Assert.IsNotEmpty(dex.Descriptions);
        }

        [Test]
        public async Task Get_Jirachi_Pokemon()
        {
            _flurlTest
                .RespondWith(Responses.JirachiPokemon);
            PokeClient pc = new PokeClient();
            var dex = await pc.Get<Pokemon>("jirachi");
            Assert.IsNotNull(dex.Name);
        }

        [Test]
        public async Task Get_Caterpie_Pokemon()
        {
            _flurlTest
                .RespondWith(Responses.CaterpiePokemon);
            PokeClient pc = new PokeClient();
            var pokemon = await pc.Get<Pokemon>(10);
            Assert.IsNotNull(pokemon.Name);
        }

        [Test]
        public async Task Get_Caterpie_Encounters_Classic()
        {
            _flurlTest
                .RespondWith(Responses.CaterpiePokemon)
                .RespondWith(Responses.CaterpieLocationAreaEncounters);
            PokeClient pc = new PokeClient();
            var pokemon = await pc.Get<Pokemon>(10);
            var encounters = await pc.GetListByUrlPart<LocationAreaEncounter>(pokemon.LocationAreaEncounters);
            Assert.IsNotEmpty(encounters);
        }

        [Test]
        public async Task Get_Caterpie_Encounters_Extension()
        {
            _flurlTest
                .RespondWith(Responses.CaterpiePokemon)
                .RespondWith(Responses.CaterpieLocationAreaEncounters);
            PokeClient pc = new PokeClient();
            var pokemon = await pc.Get<Pokemon>(10);
            var encounters = await pokemon.LocationAreaEncounters.GetResourceList<LocationAreaEncounter>();
            Assert.IsNotEmpty(encounters);
        }
    }
}
