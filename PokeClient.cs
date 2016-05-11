using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Jirapi.Resources;
using SystemType = System.Type;

namespace Jirapi
{
    public class PokeClient
    {
        public const string EndpointV2 = "http://pokeapi.co/api/v2/";

        #region Resource endpoints dictionary

        private static readonly Dictionary<SystemType, string> _urlOfType = new Dictionary<SystemType, string>
        {
            //{ typeof(ContestEffect     ), "contest-effect"       },
            //{ typeof(SuperContestEffect), "super-contest-effect" },
            //{ typeof(Characteristic    ), "characteristic"       },

            {typeof(Berry), "berry"},
            {typeof(BerryFirmness), "berry-firmness"},
            {typeof(BerryFlavor), "berry-flavor"},

            //{ typeof(ContestType), "contest-type" },

            {typeof(EncounterMethod), "encounter-method"},
            {typeof(EncounterCondition), "encounter-condition"},
            {typeof(EncounterConditionValue), "encounter-condition-value"},
            {typeof(EvolutionChain), "evolution-chain"},
            {typeof(EvolutionTrigger), "evolution-trigger"},
            {typeof(Generation), "generation"},
            {typeof(Pokedex), "pokedex"},
            //{ typeof(GameVersion ), "version"       },
            {typeof(VersionGroup), "version-group"},
            {typeof(Item), "item"},
            {typeof(ItemAttribute), "item-attribute"},
            {typeof(ItemCategory), "item-category"},
            {typeof(ItemFlingEffect), "item-fling-effect"},
            {typeof(ItemPocket), "item-pocket"},
            {typeof(Move), "move"},
            //{ typeof(MoveAilment    ), "move-ailment"      },
            //{ typeof(MoveBattleStyle), "move-battle-style" },
            //{ typeof(MoveCategory   ), "move-category"     },
            {typeof(MoveDamageClass), "move-damage-class"},
            {typeof(MoveLearnMethod), "move-learn-method"},
            //{ typeof(MoveTarget     ), "move-target"       },

            {typeof(Location), "location"},
            {typeof(LocationArea), "location-area"},
            {typeof(PalParkArea), "pal-park-area"},
            {typeof(Region), "region"},
            {typeof(Ability), "ability"},
            {typeof(EggGroup), "egg-group"},
            {typeof(Gender), "gender"},
            //{ typeof(GrowhtRate    ), "growth-rate"     },
            {typeof(Nature), "nature"},
            //{ typeof(PokeathlonStat), "pokeathlon-stat" },
            {typeof(Pokemon), "pokemon"},
            {typeof(PokemonColor), "pokemon-color"},
            {typeof(PokemonForm), "pokemon-form"},
            { typeof(PokemonHabitat), "pokemon-habitat" },
            {typeof(PokemonShape), "pokemon-shape"},
            {typeof(PokemonSpecies), "pokemon-species"},
            {typeof(Stat), "stat"},
            {typeof(PokemonType), "type"},
            {typeof(Language), "language"}
        };

        #endregion

        public async Task<T> GetByUrl<T>(string url)
        {
            string pathSegment;
            if (_urlOfType.TryGetValue(typeof(T), out pathSegment))
            {
                return await url
                    .GetJsonAsync<T>();
            }
            throw new Exception($"Support for {typeof(T).Name} is not implemented yet");
        }

        public async Task<T> Get<T>(int id)
        {
            return await Get<T>(id.ToString());
        }

        public async Task<T> Get<T>(string name)
        {
            string pathSegment;
            if (_urlOfType.TryGetValue(typeof(T), out pathSegment))
            {
                return await EndpointV2.AppendPathSegments(pathSegment, name)
                    .GetJsonAsync<T>();
            }
            throw new Exception($"Support for {typeof(T).Name} is not implemented yet");
        }

        public async Task<ApiResourceList<T>> GetResourceList<T>(int offset = 0, int limit = 20)
        {
            string pathSegment;
            if (_urlOfType.TryGetValue(typeof(T), out pathSegment))
            {
                return await EndpointV2.AppendPathSegments(pathSegment)
                    .SetQueryParams(new { limit, offset })
                    .GetJsonAsync<ApiResourceList<T>>();
            }
            throw new Exception($"Support for {typeof(T).Name} is not implemented yet");
        }
    }
}