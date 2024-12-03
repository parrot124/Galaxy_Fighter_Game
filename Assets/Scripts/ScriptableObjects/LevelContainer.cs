using Assets.Scripts.ScriptableObjects;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.ScriptableObjects
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

        private void OnEnable()
        {
            if (levels == null)
            {
                throw new NullReferenceException("Levels not set");
            }
        }
    }
}