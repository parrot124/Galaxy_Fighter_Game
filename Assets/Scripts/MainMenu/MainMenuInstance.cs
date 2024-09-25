using Assets.Scripts.MainMenu.StateMachine;
using UnityEngine;

public class MainMenuInstance : MonoBehaviour
{
    private MainMenuStateMachine mainMenuStateMachine;

    private void Awake()
    {
        mainMenuStateMachine = new MainMenuStateMachine();

        mainMenuStateMachine.EnterIn<MainMenuState>();
    }
}
