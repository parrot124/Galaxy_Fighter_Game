using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : MonoBehaviour
{
    private Button playButton;
    private Button settingsButton;
    private Button quitButton;

    public static event Action QuitPressedEvent;
    public static event Action SettingsPressedEvent;
    public static event Action PlayPressedEvent;

    void OnEnable()
    {
        List<Button> buttons = GetComponentsInChildren<Button>().ToList();

        //stupid
        playButton = buttons.Find(x => x.gameObject.name == "Play");
        settingsButton = buttons.Find(x => x.gameObject.name == "Settings");
        quitButton = buttons.Find(x => x.gameObject.name == "Quit");

        playButton.onClick.AddListener(OnPlayPressed);
        settingsButton.onClick.AddListener(OnSettingsPresed);
        quitButton.onClick.AddListener(OnQuitPressed);
    }

    private void OnDisable()
    {
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