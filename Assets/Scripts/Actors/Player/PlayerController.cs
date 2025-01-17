using GameScripts.Input;
using System;
using UnityEngine;
using Zenject;

public class PlayerController : MonoBehaviour
{
    private InputReader inputReader;

    private Vector2 movement;
    private float speed;
    private bool shooting;

    [Inject]
    private void Construct(LazyInject<InputReader> input)
    {
        inputReader = input.Value;
    }

    private void Start()
    {
        movement = Vector2.zero;
        speed = 1.0f;

        inputReader.MovementEvent += OnMovement;
        inputReader.ShootEvent += OnShoot;
    }

    private void OnShoot(bool value)
    {
        shooting = value;
    }

    private void Update()
    {
        transform.Translate(movement * Time.deltaTime);
    }

    private void OnMovement(Vector2 newMovement)
    {
        movement = newMovement * speed;
    }
}