namespace Jirapi.Resources
{
    public class Stat
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //[JsonProperty("game_index")]
        public int GameIndex { get; set; }


        //[JsonProperty("is_battle_only")]
        public bool IsBattleOnly { get; set; }

        //[JsonProperty("affecting_moves")]
        public MoveStatAffectSets AffectingMoves { get; set; }

        //[JsonProperty("affecting_natures")]
        public NatureStatAffectSets AffectingNatures { get; set; }
    }
}