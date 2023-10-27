namespace EnchantaPlay {
    public class Game {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Draw { get; private set; }

        public Game(string title, string description, string draw) { 
            this.Title = title;
            this.Description = description;
            this.Draw = draw;
        }
    }
}
