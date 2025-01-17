using GameScripts.Static;
using ScriptableObjects;
using UnityEngine.UI;
using UnityEngine;
using System;

public class LevelSelector : MonoBehaviour
{
    public static LevelSelector Instance { get; private set; }
    public static Action<Level> LevelSelected;

    public void RegisterButton(LevelDataDisplay levelDataDisplay)
    {
        if (Instance == null) throw new Exception("LevelSelector is off");

        levelDataDisplay.ClickedEvent += OnRegisteredButtonClick;
    }

    private void OnRegisteredButtonClick(Level level)
    {
        LevelSelected?.Invoke(level);
    }

    private void OnEnable()
    {
        Instance = this;

        var backButton = transform.GetChild(0).GetComponentInChildren<Button>();
        Helpers.MainMenuButtonEventsDict.TryAdd("Back", backButton.onClick);
    }

    private void OnDisable()
    {
        Instance = null;
    }
}