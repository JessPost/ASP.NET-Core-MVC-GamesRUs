namespace GamingStore.Models
{
    public class Repository
    {
        private static List<Game> _gamelist = new List<Game>();

        public static IEnumerable<Game> ListOfGames { get { return _gamelist; } }

        public static void AddGame(Game game)
        {
            _gamelist.Add(game);
        }
    }
}
