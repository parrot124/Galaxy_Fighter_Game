using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "Scriptable Objects/Level")]
public class Level : ScriptableObject
{
    public float SpawnRate => spawnRate;
    public string Name => name;
    public string Description => description;
    public List<Enemy> EnemyList => enemies;

    [SerializeField] private float spawnRate;
    [SerializeField] private string levelName;
    [SerializeField] private string description;
    [SerializeField] private List<Enemy> enemies;

    public Level(string name, string description, List<Enemy> enemies)
    {
        this.name = name;
        this.description = description;
        this.enemies = enemies;
    }
}