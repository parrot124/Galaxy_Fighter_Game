using GameScripts.Static;
using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Actors.Player
{
    public class Player
    {
        public event Action<PlayerStats> StatsChangedEvent;

        public PlayerStats Stats
        {
            get => stats;
            private set
            {
                stats = value;
                StatsChangedEvent?.Invoke(stats);
            }
        }

        private PlayerController controller;
        private GameObject playerGameObject;
        private PlayerStats stats;

        public Player()
        {
            playerGameObject = Helpers.GameHelper.PlayerGameObject;
            controller = playerGameObject.GetOrAddComponent<PlayerController>();

            Stats = new();
        }
    }
}