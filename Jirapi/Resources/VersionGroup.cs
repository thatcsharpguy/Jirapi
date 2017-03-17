using System.Collections.Generic;

namespace Jirapi.Resources
{
    public class VersionGroup
    {
        public int Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        ///     Order for sorting. Almost by date of release, except similar versions are grouped together.
        /// </summary>
        /// <value>The order.</value>
        public int Order { get; set; }

        /// <summary>
        ///     The generation this version was introduced in.
        /// </summary>
        /// <value>The generation.</value>
        public List<NamedApiResource<Generation>> Generation { get; set; }

        /// <summary>
        ///     A list of methods in which Pokémon can learn moves in this version group.
        /// </summary>
        /// <value>The move learn methods.</value>
        public List<NamedApiResource<MoveLearnMethod>> MoveLearnMethods { get; set; }

        /// <summary>
        ///     The name of this version group listed in different languages.
        /// </summary>
        /// <value>The names.</value>
        public List<Name> Names { get; set; }

        /// <summary>
        ///     A list of Pokédexes introduces in this version group.
        /// </summary>
        /// <value>The pokedexes.</value>
        public List<NamedApiResource<Pokedex>> Pokedexes { get; set; }
    }
}