namespace PlayerStats
{
    class Player
    {
        private float highScore;
        private int playedGames;
        private int wonGames;
        public string Name { get; }

        public Player(string name)
        {
            Name = name;
        }
    }
}