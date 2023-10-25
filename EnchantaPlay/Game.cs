namespace EnchantaPlay {
    public class Game {
        public string title { get; private set; }
        public string description { get; private set; }
        public string image { get; private set; }

        public Game(string title, string description, string image) { 
            this.title = title;
            this.description = description;
            this.image = image;
        }
    }
}
