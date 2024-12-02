using Assets.Scripts.UI;

namespace Assets.Scripts.MainMenu.StateMachine
{
    internal class MainMenuWindow : Window, IMainMenuState
    {
        public MainMenuWindow() : base(MainMenuView.Instance.transform.GetChild(0).gameObject)
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
