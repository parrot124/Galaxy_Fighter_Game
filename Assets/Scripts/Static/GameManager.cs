using UnityEngine;
using Assets.Scripts.Static;
using UnityEngine.SceneManagement;

public static class GameManager
{
    static GameManager()
    {
        LevelSelector.OnLevelSelected += LoadLevel;
        levelContainer = (LevelContainer)Resources.Load(GameConstants.LEVEL_CONTAINER_PATH);
    }

    public static Level CurrentLevel { get; private set; }
    public static LevelContainer levelContainer;

    private static void LoadLevel(Level level)
    {
        CurrentLevel = level;
        SceneManager.LoadScene(Scenes.GameScene);
    }
}