using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }
    }
}
