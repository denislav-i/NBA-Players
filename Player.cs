namespace NBAPlayers
{
    public class Player
    {
        private string name;
        private int playingSince;
        private string position;
        private int rating;

        public Player()
        {

        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int PlayingSince
        {
            get { return this.playingSince; }
            set { this.playingSince = value; }
        }

        public string Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public int Rating
        {
            get { return this.rating; }
            set { this.rating = value; }
        }

    }
}
