using System.Collections.Generic;
using UnityEngine;

public class LevelSelector : MonoBehaviour
{
    public static event LevelDelegate OnLevelSelected;
    public delegate void LevelDelegate(Level level);

    [SerializeField] private LevelContainer _levelContainer;
    private List<Level> _levels = new List<Level>();
    private Level _selectedLevel;

    private void Awake()
    {
        _levels = _levelContainer.Levels;
    }

    private void SelectLevel()
    {
        OnLevelSelected?.Invoke(_selectedLevel);
    }
}
