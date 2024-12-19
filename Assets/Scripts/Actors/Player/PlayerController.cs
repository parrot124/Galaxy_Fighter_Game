using GameScripts.Input;
using UnityEngine;
using Zenject;

public class PlayerController : MonoBehaviour
{
    private LazyInject<InputReader> inputReader;

    private Vector2 movement;
    private float speed;

    [Inject]
    private void Construct(LazyInject<InputReader> input)
    {
        inputReader = input;
    }

    private void Start()
    {
        movement = Vector2.zero;
        speed = 1.0f;

        inputReader.Value.MovementEvent += OnMovement;
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