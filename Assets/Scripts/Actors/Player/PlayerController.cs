using GameScripts.Input;
using UnityEngine;
using Zenject;

public class PlayerController : MonoBehaviour
{
    [Inject] private InputReader inputReader;

    private Vector2 movement;
    private float speed;

    private void Start()
    {
        movement = Vector2.zero;
        inputReader.MovementEvent += OnMovement;
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