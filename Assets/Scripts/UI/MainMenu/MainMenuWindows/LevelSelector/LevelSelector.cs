using ScriptableObjects;
using UnityEngine.UI;
using UnityEngine;
using System;
using GameScripts.Static;

public class LevelSelector : MonoBehaviour
{
    public static LevelSelector Instance { get; private set; }
    public static Action<Level> OnLevelSelected;

    public void RegisterButton(LevelDataDisplay levelDataDisplay)
    {
        if (Instance == null) throw new Exception("LevelSelector is off");

        levelDataDisplay.OnClick += OnRegisteredButtonClick;
    }

    private void OnRegisteredButtonClick(Level level)
    {
        OnLevelSelected?.Invoke(level);
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