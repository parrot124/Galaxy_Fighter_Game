using System.Collections.Generic;
using GameScripts.Static;
using Actors;

namespace LevelContext.Factories
{
    public class EnemyCreator
    {
        private float spawnRate;
        private List<Enemy> enemies;

        public EnemyCreator()
        {
            spawnRate = GameManager.CurrentLevel.SpawnRate;
            enemies = GameManager.CurrentLevel.EnemyList;
        }
    }
}