using System;
using UnityEngine;

namespace Actors
{
    public class Enemy : MonoBehaviour
    {
        public event Action Died;

        public GameObject Prefab { get; private set; }
        private float Health
        {
            get => health;
            set
            {
                health = value;
                if (health < 0)
                {
                    Died?.Invoke();
                }
            }
        }
        private float health;
    }
}