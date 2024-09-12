using System;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public event Action OnDeath;

    protected float Health
    {
        get => health;
        set
        {
            health = value;
            if (health < 0)
            {
                OnDeath.Invoke();
            }
        }
    }

    protected float health;
}
