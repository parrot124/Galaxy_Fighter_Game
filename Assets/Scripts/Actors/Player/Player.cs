using GameScripts.Static;
using UnityEngine;
using System;
using Zenject;
using Unity.VisualScripting;

namespace Actors.Player
{
    public class Player
    {
        public event Action<PlayerStats> StatsChangedEvent;

        private PlayerController controller;
        private GameObject playerGameObject;

        public PlayerStats Stats
        {
            get => stats;
            private set
            {
                stats = value;
                StatsChangedEvent?.Invoke(stats);
            }
        }

        private PlayerStats stats;

        public Player()
        {
            playerGameObject = Helpers.GameHelper.PlayerGameObject;
            controller = playerGameObject.GetOrAddComponent<PlayerController>();

            Stats = new();
        }
    }
}