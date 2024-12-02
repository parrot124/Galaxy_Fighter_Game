using Assets.Scripts.MainMenu.StateMachine;
using UnityEngine;
using System;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public static LevelSelector Instance { get; private set; }
    public static event Action BackButtonPressedEvent;

    private Button backButton;
    public static Action<Level> OnLevelSelected;

    private LevelSelectionWindow levelSelectionWindowController;

    private void OnEnable()
    {
        Instance = this;

        backButton = transform.GetChild(0).GetComponentInChildren<Button>();
        backButton.onClick.AddListener(OnBackPressed);
    }

    private void OnBackPressed()
    {
        BackButtonPressedEvent?.Invoke();
    }

    private void OnDisable()
    {
        Instance = null;
    }
}