using System;

namespace Assets.Scripts.MainMenu.StateMachine
{
    internal class LevelSelectionState : IMainMenuState
    {
        private readonly MainMenuStateMachine mainMenuStateMachine;

        public LevelSelectionState(MainMenuStateMachine mainMenuStateMachine)
        {
            this.mainMenuStateMachine = mainMenuStateMachine;
        }

        public void Enter()
        {
            throw new NotImplementedException();
        }

        public void Exit()
        {
            //im not sure this is ok
            mainMenuStateMachine.EnterIn<MainMenuState>();
        }
    }
}
