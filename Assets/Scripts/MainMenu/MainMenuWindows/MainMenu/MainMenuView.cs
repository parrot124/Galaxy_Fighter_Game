using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The "View" component of the main menu main section
/// </summary>
public class MainMenuView : MonoBehaviour
{
    public static MainMenuView Instance { get; private set; }

    private Button playButton;
    private Button settingsButton;
    private Button quitButton;

    public static event Action PlayPressedEvent;
    public static event Action SettingsPressedEvent;
    public static event Action QuitPressedEvent;

    void OnEnable()
    {
        Instance = this;

        List<Button> buttons = transform.GetChild(0).GetComponentsInChildren<Button>().ToList();

        //cringe
        playButton = buttons.Find(x => x.gameObject.name == "Play");
        settingsButton = buttons.Find(x => x.gameObject.name == "Settings");
        quitButton = buttons.Find(x => x.gameObject.name == "Quit");

        playButton.onClick.AddListener(OnPlayPressed);
        settingsButton.onClick.AddListener(OnSettingsPresed);
        quitButton.onClick.AddListener(OnQuitPressed);
    }

    private void OnDisable()
    {
        Instance = null;

        playButton.onClick.RemoveListener(OnPlayPressed);
        settingsButton.onClick.RemoveListener(OnSettingsPresed);
        quitButton.onClick.RemoveListener(OnSettingsPresed);
    }

    private void OnQuitPressed()
    {
        QuitPressedEvent?.Invoke();
    }

    private void OnSettingsPresed()
    {
        SettingsPressedEvent?.Invoke();
    }

    private void OnPlayPressed()
    {
        PlayPressedEvent?.Invoke();
    }
}
