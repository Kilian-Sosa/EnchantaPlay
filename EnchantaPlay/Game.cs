namespace EnchantaPlay {
    public class Game {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }

        public Game(string title, string description, string image) { 
            this.Title = title;
            this.Description = description;
            this.Image = image;
        }
    }
}
