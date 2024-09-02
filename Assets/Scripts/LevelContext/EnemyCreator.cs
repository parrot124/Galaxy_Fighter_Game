using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemyCreator : MonoBehaviour
{
    private Level currentLevel;
    [SerializeField] private float SpawnRate;

    private void Start()
    {
        currentLevel = GameManager.CurrentLevel;
    }

    private IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(1.0f/SpawnRate);

        GameObject newEnemy = GameObject.CreatePrimitive(PrimitiveType.Plane);
        newEnemy.transform.position += ScreenBound.Top;
        newEnemy.AddComponent<Enemy>();
    }
}
