using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    /// <summary>
    /// There is only one LevelContainer in the project. Its directory is hardcoded into GameConstants
    /// </summary>
    [CreateAssetMenu(fileName = "Level Container", menuName = "Scriptable Objects/Level Container")]
    public class LevelContainer : ScriptableObject
    {
        [Header("Set in Inspector")]
        [SerializeField] private List<Level> levels;

        public List<Level> Levels => levels;
    }
}