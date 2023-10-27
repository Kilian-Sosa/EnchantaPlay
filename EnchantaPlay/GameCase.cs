namespace EnchantaPlay {
    public class GameCase {
        public Game Game { get; private set; }

        public GameCase(Game game) {
            this.Game = game;
        }

        public override string ToString() {
            int titlePadding = GetPaddingLength(Game.Title);
            string stringCase = "_____________________________________\n";
            stringCase += "/                                   \\\n";
            stringCase += "|" + new string(' ', titlePadding) + Game.Title + new string(' ', titlePadding) + "|\n";
            stringCase += "|                                   |\n";

            string[] imageArray = Game.Draw.Split(";");
            for (int i = 0; i < imageArray.Length; i++) 
                stringCase += $"|         {imageArray[i]}        |\n";
            stringCase += "|                                   |\n";
            stringCase += $"|      Platform: []                 |\n";
            stringCase += $"|      Genre:    []                 |\n";
            stringCase += $"|      Rating:   []                 |\n";
            stringCase += $"|      Players:  []                 |\n";
            stringCase += $"|      Release:  []                 |\n";
            stringCase += "|                                   |\n";
            stringCase += "\\___________________________________/\n";
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
            return (36 - chain.Length) / 2;
        }
    }
}
