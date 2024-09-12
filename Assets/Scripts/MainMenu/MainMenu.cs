using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    private Button PlayButton;
    private Button SettingsButton;
    private Button QuitButton;

    private void Awake()
    {
        //get all child buttons
        List<Button> buttons = GetComponentsInChildren<Button>().ToList();

        //i know that's a bit unefficient
        PlayButton = buttons.Find(x => x.gameObject.name == "Play");
        SettingsButton = buttons.Find(x => x.gameObject.name == "Settings");
        QuitButton = buttons.Find(x => x.gameObject.name == "Quit");

        PlayButton.onClick.AddListener(OnPlayPressed);
        SettingsButton.onClick.AddListener(OnSettingsPresed);
        QuitButton.onClick.AddListener(OnQuitPressed);
    }


    private void OnPlayPressed()
    {
        //open level selecting menu (activate/deactivate some GameObjects)
    }

    private void OnSettingsPresed()
    {
        //open settings menu
    }

    private void OnQuitPressed()
    {
        Application.Quit();
    }
}
