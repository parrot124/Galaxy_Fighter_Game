using System;
using Zenject;

namespace Actors.Player
{
    public class Player
    {
        public event Action<PlayerStats> StatsChangedEvent;

        private PlayerStats Stats
        {
            get => Stats;
            set
            {
                Stats = value;
                StatsChangedEvent?.Invoke(Stats);
            }
        }

        [Inject]
        public Player(PlayerController controller)
        {
            Stats = new();
        }


    }
}