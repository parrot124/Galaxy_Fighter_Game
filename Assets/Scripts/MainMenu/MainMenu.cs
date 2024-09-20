using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    private Button playButton;
    private Button settingsButton;
    private Button quitButton;

    private RectTransform logoRectTransform;
    private LevelSelector levelSelector;

    private void Awake()
    {
        //get all child buttons
        List<Button> buttons = GetComponentsInChildren<Button>().ToList();

        //i know this is bullshit
        logoRectTransform = GameObject.Find("Logo").GetComponent<RectTransform>();

        //i know that's a bit unefficient
        playButton = buttons.Find(x => x.gameObject.name == "Play");
        settingsButton = buttons.Find(x => x.gameObject.name == "Settings");
        quitButton = buttons.Find(x => x.gameObject.name == "Quit");

        playButton.onClick.AddListener(OnPlayPressed);
        settingsButton.onClick.AddListener(OnSettingsPresed);
        quitButton.onClick.AddListener(OnQuitPressed);
    }


    private void OnPlayPressed()
    {
        //open level selecting menu (activate/deactivate some GameObjects)

        SceneManager.LoadScene(Scenes.GameScene);
    }

    private void OnSettingsPresed()
    {
        //open settings menu

        throw new NotImplementedException();
    }

    private void OnQuitPressed()
    {
        Application.Quit();
    }
}
