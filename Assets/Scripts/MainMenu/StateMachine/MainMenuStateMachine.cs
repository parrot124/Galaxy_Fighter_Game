using System;
using System.Collections.Generic;
using Assets.Scripts.MainMenu.StateMachine;

/// <summary>
/// Defines main menu UI state. Its sections should be subscribed to OnStateChange event and activate/deactivate themselves
/// </summary>
public class MainMenuStateMachine
{
    public static event StateChangeDelegate OnStateChange;
    public delegate void StateChangeDelegate(IMainMenuState state);

    private Dictionary<Type, IMainMenuState> states;
    private IMainMenuState currentState;

    public MainMenuStateMachine()
    {
        states = new Dictionary<Type, IMainMenuState>()
        {
            [typeof(MainMenuState)] = new MainMenuState(this),
            [typeof(LevelSelectionState)] = new LevelSelectionState(this)
        };

        EnterIn<MainMenuState>();
    }

    public void EnterIn<TState>() where TState : IMainMenuState
    {
        if (states.TryGetValue(typeof(TState), out IMainMenuState state))
        {
            currentState?.Exit();
            currentState = state;
            currentState?.Enter();

            OnStateChange?.Invoke(currentState);
        }
    }
}