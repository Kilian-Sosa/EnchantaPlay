

namespace FantasyConsole {
    public class Program {
        public static void Main(string[] args) {
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
                    //PlayGame();
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

        private static void Exit() {
            Console.WriteLine("Thanks for playing!");
            Environment.Exit(0);
        }
    }
}