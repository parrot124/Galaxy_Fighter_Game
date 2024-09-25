using System;
namespace Assets.Scripts.MainMenu.StateMachine
{
    internal class MainMenuState : IMainMenuState
    {
        private readonly MainMenuStateMachine mainMenuStateMachine;

        public MainMenuState(MainMenuStateMachine mainMenuStateMachine)
        {
            this.mainMenuStateMachine = mainMenuStateMachine;
        }

        public void Enter()
        {
            throw new NotImplementedException();
        }

        public void Exit()
        {
            throw new NotImplementedException();
        }
    }
}
