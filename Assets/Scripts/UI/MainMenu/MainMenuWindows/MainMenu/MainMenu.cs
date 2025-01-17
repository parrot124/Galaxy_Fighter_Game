using System.Collections.Generic;
using GameScripts.Static;
using UnityEngine.UI;
using UnityEngine;
using System.Linq;

public class MainMenu : MonoBehaviour
{
    public static MainMenu Instance { get; private set; }

    private void OnEnable()
    {
        Instance = this;

        List<Button> buttons = transform.GetChild(0).GetComponentsInChildren<Button>().ToList();

        var playButton = buttons.Find(x => x.gameObject.name == "Play");
        var settingsButton = buttons.Find(x => x.gameObject.name == "Settings");
        var quitButton = buttons.Find(x => x.gameObject.name == "Quit");

        Helpers.MainMenuButtonEventsDict.TryAdd("Play", playButton.onClick);
        Helpers.MainMenuButtonEventsDict.TryAdd("Settings", settingsButton.onClick);
        Helpers.MainMenuButtonEventsDict.TryAdd("Quit", quitButton.onClick);
    }

    private void OnDisable()
    {
        Instance = null;
    }
}
