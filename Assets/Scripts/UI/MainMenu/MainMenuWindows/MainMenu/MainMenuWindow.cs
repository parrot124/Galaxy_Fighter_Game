using GameScripts.UI;

namespace Assets.GameScripts.MainMenu.StateMachine
{
    internal class MainMenuWindow : Window, IMainMenuState
    {
        public MainMenuWindow() : base(global::MainMenu.Instance.transform.GetChild(0).gameObject)
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
