using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreator : MonoBehaviour
{
    [SerializeField] private float SpawnRate;
    private List<Enemy> enemies;

    private void Start()
    {
        SpawnRate = GameManager.CurrentLevel.SpawnRate;
        enemies = GameManager.CurrentLevel.EnemyList;
    }

    private IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(1.0f/SpawnRate);

        GameObject newEnemy = GameObject.CreatePrimitive(PrimitiveType.Plane);
        newEnemy.transform.position += ScreenBound.Top;
        newEnemy.AddComponent<Enemy>();
    }
}