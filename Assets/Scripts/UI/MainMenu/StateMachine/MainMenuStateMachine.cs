using System;
using System.Collections.Generic;
using Assets.GameScripts.MainMenu.StateMachine;
using GameScripts.Static;
using UnityEngine;

/// <summary>
/// Defines main menu UI state
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
        Helpers.MainMenuButtonEventsDict["Play"].AddListener(EnterLevelSelectionWindow);
        Helpers.MainMenuButtonEventsDict["Back"].AddListener(EnterMainMenuWindow);
        Helpers.MainMenuButtonEventsDict["Quit"].AddListener(ExitGame);
    }

    private void ExitGame()
    {
        Application.Quit();
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