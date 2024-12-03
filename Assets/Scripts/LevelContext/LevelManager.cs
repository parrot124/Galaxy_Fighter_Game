using System;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static Transform PlayerTransform { get; private set; }

    private EnemyCreator enemyCreator;
    private Level currentLevel;

    private void Start()
    {
        ShowIntro();
        enemyCreator = gameObject.AddComponent<EnemyCreator>();
        currentLevel = GameManager.CurrentLevel;
    }

    private void ShowIntro()
    {
        //there should be coroutine start
        //show CurrentLevel name on full screen
        throw new NotImplementedException("LevelManager ShowIntro() is not implemented");
    }
}