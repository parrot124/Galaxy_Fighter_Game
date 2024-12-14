using GameScripts.UI.MainMenu.StateMachine;
using UnityEngine;

public class MainMenuInstance : MonoBehaviour
{
    private MainMenuStateMachine mainMenuStateMachine;

    private void Start()
    {
        mainMenuStateMachine = new();
    }
}
