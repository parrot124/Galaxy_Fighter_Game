using Unity.VisualScripting;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Level CurrentLevel => currentLevel;
    public static Transform PlayerTransform { get; private set; }

    private Level currentLevel;
    private EnemyCreator enemyCreator;

    void Start()
    {
        ShowIntro();
        enemyCreator = this.AddComponent<EnemyCreator>();
        currentLevel = GameManager.CurrentLevel;
    }


    private void ShowIntro()
    {
        //show CurrentLevel name on full screen
        Debug.LogError("ShowIntro() not Implemented");

        //next code should create text field game object showing label
        string label = currentLevel.Name;
    }
}