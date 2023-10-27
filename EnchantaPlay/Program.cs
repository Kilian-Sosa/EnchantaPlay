

using System.Text.Json;

namespace EnchantaPlay {
    public class Program {
        static List<Game> Games = new List<Game>();
        static List<GameCase> GameCases = new List<GameCase>();
        static string gamesPath = "games.json";
        public static void Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // For the card symbols to work
            PrintIntro();
            GetInput();
        }

        private static void PrintIntro() {
            Console.WriteLine("Welcome to EnchantaPlay!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void PrintOptions() {
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Play a game");
            Console.WriteLine("2. Develop your own game (coming soon)");
            Console.WriteLine("3. View the leaderboard");
            Console.WriteLine("4. Exit");
        }

        private static void GetInput() {
            PrintOptions();
            var input = Console.ReadLine();
            switch (input) {
                case "1":
                    ShowGames();
                    break;
                case "2":
                    //DevelopGame();
                    GetInput();
                    break;
                case "3":
                    //ViewLeaderboard();
                    GetInput();
                    break;
                case "4":
                    Exit();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    GetInput();
                    break;
            }
        }

        private static List<Game> GetGames() {
            var games = new List<Game>();
            string jsonResult = File.ReadAllText(gamesPath);
            return JsonSerializer.Deserialize<List<Game>>(jsonResult);
        }

        private static void ShowGames() {
            Console.Clear();
            if (Games.Count == 0) Games = GetGames();
            if (GameCases.Count == 0) {
                GameCases = new List<GameCase>();
                foreach (var game in Games) GameCases.Add(new GameCase(game));
            }

            for (int i = 0; i < 20; i++) {
                foreach (var game in GameCases) 
                    Console.Write($"{AnsiColor.Green} {game.ToString().Split('\n')[i]} ");
                Console.WriteLine(AnsiColor.Reset);
            }
        }

        private static void Exit() {
            Console.WriteLine("Thanks for playing!");
            Environment.Exit(0);
        }
    }
}