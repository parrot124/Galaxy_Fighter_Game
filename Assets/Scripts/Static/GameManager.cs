using ScriptableObjects;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace GameScripts.Static
{
    public static class GameManager
    {
        public static Level CurrentLevel { get; private set; }
        public static LevelContainer LevelContainer;

        static GameManager()
        {
            LevelSelector.OnLevelSelected += LoadLevel;
            LevelContainer = Resources.Load(GameConstants.LevelContainerPath) as LevelContainer;
        }

        private static void LoadLevel(Level level)
        {
            CurrentLevel = level;
            SceneManager.LoadScene(Scenes.GameScene);
        }
    }
}