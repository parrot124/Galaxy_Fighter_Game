using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// ”правл€ет уровнем
/// </summary>
public class LevelManager : MonoBehaviour
{
    public Level CurrentLevel => currentLevel;

    private Level currentLevel;
    private EnemyCreator enemyCreator;

    void Start()
    {
        //ShowIntro();
        enemyCreator = this.AddComponent<EnemyCreator>();
        currentLevel = GameManager.CurrentLevel;
    }


    private void ShowIntro()
    {
        //show CurrentLevel name on full screen
        Debug.LogError("ShowIntro() not Implemented");
    }
}
