namespace PlayerStats
{
    class Player
    {
        private float highScore;
        private int playedGames;
        private int wonGames;
        public string Name { get; }

        public float HighScore
        {
            get
            {
                return highScore;
            }
            set
            {
                if (value > highScore) highScore = value;
            }
        }

        public float WinRate
        {
            get
            {
                if (playedGames == 0)
                {
                    return 0.0f;
                }
                else
                {
                    return (float)wonGames / playedGames;
                }
            }
        }

        public Player(string name)
        {
            Name = name;
        }
    }
}