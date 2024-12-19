using ScriptableObjects;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace GameScripts.Static
{
    public static class GameManager
    {

        private static Level currentLevel;
        public static Level CurrentLevel 
        {
            get
            {
                if (currentLevel == null)
                {
                    currentLevel = LevelContainer.Levels[0];
                }
                return currentLevel;
            }
            private set 
            {
                currentLevel = value;
            } 
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