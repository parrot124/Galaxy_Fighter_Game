using System;
using System.Collections.Generic;
using Assets.Scripts.MainMenu.StateMachine;

/// <summary>
/// Defines main menu UI state. Its sections should be subscribed to OnStateChange event and activate/deactivate themselves
/// </summary>
public class MainMenuStateMachine
{
    public static event Action<IMainMenuState> OnStateChange;

    private Dictionary<Type, IMainMenuState> states;
    private IMainMenuState currentState;

    public MainMenuStateMachine()
    {
        states = new Dictionary<Type, IMainMenuState>()
        {
            [typeof(MainMenuWindow)] = new MainMenuWindow(),
            [typeof(LevelSelectionWindow)] = new LevelSelectionWindow()
        };

        EnterIn<MainMenuWindow>();

        //subscribe to buttons events
        MainMenuView.PlayPressedEvent += EnterLevelSelectionWindow;
        LevelSelector.BackButtonPressedEvent += EnterMainMenuWindow;
    }

    private void EnterLevelSelectionWindow()
    {
        EnterIn<LevelSelectionWindow>();
    }

    private void EnterMainMenuWindow()
    {
        EnterIn<MainMenuWindow>();
    }

    private void EnterIn<TState>() where TState : IMainMenuState
    {
        if (states.TryGetValue(typeof(TState), out IMainMenuState state))
        {
            currentState?.Exit();
            currentState = state;
            currentState.Enter();

            OnStateChange?.Invoke(currentState);
        }
    }
}