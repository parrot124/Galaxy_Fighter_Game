using ScriptableObjects;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace GameScripts.Static
{
    public static class GameManager
    {
        public static Level CurrentLevel 
        {
            get
            {
                if (CurrentLevel == null) { return LevelContainer.Levels[0]; }
                else return CurrentLevel;
            }
            private set { } 
        }
        public static LevelContainer LevelContainer;

        static GameManager()
        {
            LevelSelector.LevelSelected += LoadLevel;
            LevelContainer = Resources.Load(GameConstants.LevelContainerPath) as LevelContainer;
        }

        private static void LoadLevel(Level level)
        {
            CurrentLevel = level;
            SceneManager.LoadScene(Scenes.GameScene);
        }
    }
}