using System;
using System.Threading.Tasks;
using Flurl.Http.Testing;
using Jirapi.Resources;
using NUnit.Framework;

namespace Jirapi.Test
{
    [TestFixture]
    public class TestOne
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
/*
        [Test]
        public async Task Query_NamedApiResource()
        {
            _flurlTest
                .RespondWith(Responses.Bulbasaur)
                .RespondWith(Responses.BulbasaurSpecies);
            PokeClient pc = new PokeClient();
            var pokemon = await pc.Get<Pokemon>("bulbasaur");
            var species = await pc.Get<PokemonSpecies>(pokemon.Species.Name);
            Assert.IsNotNull(pokemon.Species.Resource);
        }
*/        
    }
}
