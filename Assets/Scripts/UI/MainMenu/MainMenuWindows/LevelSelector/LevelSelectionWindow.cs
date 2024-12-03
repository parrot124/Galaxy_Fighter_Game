using Assets.Scripts.UI;

namespace Assets.Scripts.MainMenu.StateMachine
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