namespace EnchantaPlay {
    public class Game {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Draw { get; private set; }
        public string Color { get; private set; }

        public Game(string title, string description, string draw, string color) { 
            this.Title = title;
            this.Description = description;
            this.Draw = draw;
            this.Color = color;
        }
    }
}
