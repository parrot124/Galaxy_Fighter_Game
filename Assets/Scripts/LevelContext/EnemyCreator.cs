using System.Collections.Generic;
using GameScripts.Static;
using UnityEngine;
using Actors;
using System;

namespace LevelContext.Factories
{
    //TODO: Make object pool optimization later
    public class EnemyCreator
    {
        private float spawnRate;
        private Queue<Enemy> enemies;

        public EnemyCreator()
        {
            spawnRate = GameManager.CurrentLevel.SpawnRate;
            enemies = new Queue<Enemy>(GameManager.CurrentLevel.EnemyList);
        }

        public Enemy ProduceEnemy()
        {
            GameObject.Instantiate(enemies.Dequeue().gameObject);
            throw new NotImplementedException();
        }
    }
}