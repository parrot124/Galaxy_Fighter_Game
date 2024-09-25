using System;
using System.Collections.Generic;
using Assets.Scripts.MainMenu.StateMachine;

public class MainMenuStateMachine
{
    private Dictionary<Type, IMainMenuState> states;
    private IMainMenuState currentState;

    public MainMenuStateMachine()
    {
        states = new Dictionary<Type, IMainMenuState>()
        {
            [typeof(MainMenuState)] = new MainMenuState(this),
            [typeof(LevelSelectionState)] = new LevelSelectionState(this)
        };
    }

    public void EnterIn<TState>() where TState : IMainMenuState
    {
        if (states.TryGetValue(typeof(TState), out IMainMenuState state))
        {
            currentState?.Exit();
            currentState = state;
            currentState?.Enter();
        }
    }
}
