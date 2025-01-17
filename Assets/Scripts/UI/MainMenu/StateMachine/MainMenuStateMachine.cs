using System;
using System.Collections.Generic;
using Assets.GameScripts.MainMenu.StateMachine;
using GameScripts.Static;
using UnityEngine;

namespace GameScripts.UI.MainMenu.StateMachine
{
    /// <summary>
    /// Defines main menu UI state
    /// </summary>
    public class MainMenuStateMachine
    {
        public static event Action<IMainMenuState> StateChangedEvent;

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

            Helpers.MainMenuButtonEventsDict["Play"].AddListener(EnterLevelSelectionWindow);
            Helpers.MainMenuButtonEventsDict["Back"].AddListener(EnterMainMenuWindow);
            Helpers.MainMenuButtonEventsDict["Quit"].AddListener(ExitGame);
        }

        private void EnterIn<TState>() where TState : IMainMenuState
        {
            if (states.TryGetValue(typeof(TState), out IMainMenuState state))
            {
                currentState?.Exit();
                currentState = state;
                currentState.Enter();

                StateChangedEvent?.Invoke(currentState);
            }
        }
        private void EnterLevelSelectionWindow()
        {
            EnterIn<LevelSelectionWindow>();
        }

        private void EnterMainMenuWindow()
        {
            EnterIn<MainMenuWindow>();
        }

        private void ExitGame()
        {
            Application.Quit();
        }
    }
}