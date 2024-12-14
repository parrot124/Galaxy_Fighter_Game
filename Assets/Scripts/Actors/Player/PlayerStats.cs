namespace Actors.Player
{
    public class PlayerStats
    {
        public int PlayerId;
        public int Score;
        public int Health;

        public PlayerStats(int playerId = 0, int score = 0, int health = 0)
        {
            PlayerId = playerId;
            Score = score;
            Health = health;
        }
    }
}
