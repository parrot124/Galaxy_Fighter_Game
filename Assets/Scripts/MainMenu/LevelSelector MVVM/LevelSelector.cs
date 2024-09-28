using System.Collections.Generic;
using UnityEngine;

// TODO: Refactoring
public class LevelSelector : MonoBehaviour
{
    public static event LevelDelegate OnLevelSelected;
    public delegate void LevelDelegate(Level level);

    [SerializeField] private LevelContainer levelContainer;
    private List<Level> levels = new List<Level>();
    public List<Level> LevelList => levels;

    private void Awake()
    {
        levels = levelContainer.Levels;
    }
}