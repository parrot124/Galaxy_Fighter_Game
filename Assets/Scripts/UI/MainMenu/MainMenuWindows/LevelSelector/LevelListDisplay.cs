using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;
using GameScripts.Static;

public class LevelListDisplay : MonoBehaviour
{
    private List<Level> levels;
    private List<GameObject> elements;
    private List<LevelDataDisplay> displays;

    public Level GetLevel(LevelDataDisplay dataDisplay)
    {
        int index = displays.FindIndex(x => x == dataDisplay);

        return levels[index];
    }

    private void Awake()
    {
        elements = new List<GameObject>();
        displays = new List<LevelDataDisplay>();

        levels = GameManager.LevelContainer.Levels;

        foreach (var level in levels)
        {
            var newElement = Instantiate(Resources.Load(GameConstants.LevelListDisplayElementPrefabPath) as GameObject);
            var display = newElement.GetComponent<LevelDataDisplay>();

            elements.Add(newElement);
            displays.Add(display);

            newElement.transform.SetParent(transform, false);
        }
    }
}
