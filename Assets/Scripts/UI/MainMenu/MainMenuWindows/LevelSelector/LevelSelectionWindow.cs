using GameScripts.UI;

namespace Assets.GameScripts.MainMenu.StateMachine
{
    internal class LevelSelectionWindow : Window, IMainMenuState
    {
        public LevelSelectionWindow() : base(LevelSelector.Instance.transform.GetChild(0).gameObject)
        {

        }

        public void Enter()
        {
            ShowWindow();
        }

        public void Exit()
        {
            HideWindow();
        }
    }
}