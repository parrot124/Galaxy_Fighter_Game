using UnityEngine;
using Assets.Scripts.Static;
using UnityEngine.SceneManagement;

public static class GameManager
{
    static GameManager()
    {
        LevelSelector.OnLevelSelected += LoadLevel;
        LevelContainer = (LevelContainer)Resources.Load(GameConstants.LEVEL_CONTAINER_PATH);
    }

    public static Level CurrentLevel { get; private set; }
    public static LevelContainer LevelContainer;

    private static void LoadLevel(Level level)
    {
        CurrentLevel = level;
        SceneManager.LoadScene(Scenes.GameScene);
    }
}