namespace Actors.Player
{
    public class PlayerStats
    {
        public int Score;
        public int Health;

        public PlayerStats(int playerId = 0, int score = 0, int health = 0)
        {
            Score = score;
            Health = health;
        }
    }
}
