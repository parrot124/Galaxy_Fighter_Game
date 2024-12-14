using System.Collections.Generic;
using GameScripts.Static;
using UnityEngine;
using Actors;

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
            return GameObject.Instantiate(enemies.Dequeue());
        }
    }
}