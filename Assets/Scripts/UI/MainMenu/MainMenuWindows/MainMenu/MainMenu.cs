using System.Collections.Generic;
using GameScripts.Static;
using System.Linq;
using UnityEngine.UI;
using UnityEngine;

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

        Helpers.ButtonEventsDict.TryAdd("Play", playButton.onClick);
        Helpers.ButtonEventsDict.TryAdd("Settings", settingsButton.onClick);
        Helpers.ButtonEventsDict.TryAdd("Quit", quitButton.onClick);
    }

    private void OnDisable()
    {
        Instance = null;
    }
}
