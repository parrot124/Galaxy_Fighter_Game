using Actors;
using GameScripts.Static;
using System.Collections.Generic;
using UnityEngine;

namespace LevelContext.Factories
{
    //TODO: Make object pool optimization later
    public class EnemyCreator
    {
        private Queue<Enemy> enemies;

        public EnemyCreator()
        {
            enemies = new(GameManager.CurrentLevel.EnemyList);
        }

        public Enemy ProduceEnemy()
        {
            return Object.Instantiate(enemies.Dequeue().Prefab).GetComponent<Enemy>();
        }
    }
}