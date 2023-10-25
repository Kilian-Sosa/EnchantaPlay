namespace EnchantaPlay {
    public class GameCase {
        public Game game { get; private set; }

        public GameCase(Game game) {
            this.game = game;
        }

        public string ToString() {
            int titlePadding = GetPaddingLength(game.title);
            string stringCase = "_________________________________________\n";
            stringCase += "/                                       \n";
            stringCase += "|" + new string(' ', titlePadding) + game.title + new string(' ', titlePadding) + "|\n";
            stringCase += "|                                        |\n";

            string[] imageArray = game.image.Split(".");
            for (int i = 0; i < imageArray.Length; i++) 
                stringCase += $"|          {imageArray[i]}          |\n";
            stringCase += "|                                        |\n";
            stringCase += $"|      Platform: []                   |\n";
            stringCase += $"|      Genre:    []                   |\n";
            stringCase += $"|      Rating:   []                   |\n";
            stringCase += $"|      Players:  []                   |\n";
            stringCase += $"|      Release:  []                   |\n";
            stringCase += "|                                        |\n";
            stringCase += "\\_________________________________________/\n";
            return stringCase;

            // ________________________________________
            // /                                      \
            // |                Title                 |
            // |                                      |
            // |          +----------------+          |
            // |          |                |          |
            // |          |                |          |
            // |          |                |          |
            // |          |                |          |
            // |          |                |          |
            // |          |                |          |
            // |          +----------------+          |
            // |                                      |
            // |      Platform: [ ]                   |
            // |      Genre:    [ ]                   |
            // |      Rating:   [ ]                   |
            // |      Players:  [ ]                   |
            // |      Release:  [ ]                   |
            // |                                      |
            // \______________________________________/
        }
        private int GetPaddingLength(string chain) {
            return (40 - chain.Length) / 2;
        }
    }
}
