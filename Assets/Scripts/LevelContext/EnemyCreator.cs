using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class EnemyCreator : MonoBehaviour
{
    [SerializeField] private float spawnRate;
    private List<Enemy> enemies;

    private void Start()
    {
        spawnRate = GameManager.CurrentLevel.SpawnRate;
        enemies = GameManager.CurrentLevel.EnemyList;
    }

    private IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(1.0f/spawnRate);

        GameObject newEnemy = GameObject.CreatePrimitive(PrimitiveType.Plane);
        newEnemy.transform.position += ScreenBound.Top;
        newEnemy.AddComponent<Enemy>();
    }
}
