using System.Collections.Generic;
using UnityEngine;
using Actors;

namespace ScriptableObjects
{
    /// <summary>
    /// Create this object to do new levels. Don't forget to put them in LevelContainer if you want it to be displayed in main menu
    /// </summary>
    [CreateAssetMenu(fileName = "Level", menuName = "Scriptable Objects/Level")]
    public class Level : ScriptableObject
    {
        public float SpawnRate => spawnRate;
        public string Name => levelName;
        public string Description => description;
        public List<Enemy> EnemyList => enemies;

        [SerializeField] private float spawnRate;
        [SerializeField] private string levelName;
        [SerializeField] private string description;
        [SerializeField] private List<Enemy> enemies;
    }
}