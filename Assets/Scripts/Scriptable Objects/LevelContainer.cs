using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level Container", menuName = "Scriptable Objects/Level Container")]
class LevelContainer : ScriptableObject
{
    [Header("Set in Inspector")]
    [SerializeField] private List<Level> levels;

    public List<Level> Levels => levels;

    private void OnEnable()
    {
        if (levels == null)
        {
            throw new NullReferenceException("Levels not set");
        }
    }
}