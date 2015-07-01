namespace MinesweeperGame
{
    public class Score
    {
        private string playerName;
        private int playerPoints;

        public Score() 
        {
        }

        public Score(string name, int points)
        {
            this.PlayerName = name;
            this.PlayerPoints = points;
        }

        public string PlayerName
        {
            get { return this.playerName; }
            set { this.playerName = value; }
        }

        public int PlayerPoints
        {
            get { return this.playerPoints; }
            set { this.playerPoints = value; }
        }
    }
}
