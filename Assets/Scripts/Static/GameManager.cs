using UnityEngine.SceneManagement;

public static class GameManager
{
    static GameManager()
    {
        LevelSelector.OnLevelSelected += LoadLevel;
    }

    public static Level CurrentLevel { get; private set; }

    private static void LoadLevel(Level level)
    {
        CurrentLevel = level;
        SceneManager.LoadScene(Scenes.GameScene);
    }
}