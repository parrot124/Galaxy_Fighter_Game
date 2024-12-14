using UnityEngine;
using System;

namespace Actors
{
    public class Entity : MonoBehaviour
    {
        public event Action Died;

        protected float Health
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

        protected float health;
    }
}