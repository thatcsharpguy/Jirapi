using System.Collections.Generic;

namespace Jirapi.Resources
{
    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TypeRelations DamageRelations { get; set; }
        public List<GenerationGameIndex> GameIndices { get; set; }
        public NamedApiResource<Generation> Generation { get; set; }
        public NamedApiResource<MoveDamageClass> MoveDamageClass { get; set; }
        public List<Name> Names { get; set; }
        public TypePokemon Pokemon { get; set; }
        public List<NamedApiResource<Move>> Moves { get; set; }
    }
}