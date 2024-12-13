using GameScripts.Input;
using UnityEngine;
using Zenject;

public class PlayerController : MonoBehaviour
{
    [Inject] private InputReader inputReader;

    private float speed;
    private Vector2 movement;

    void Start()
    {
        movement = Vector2.zero;
        inputReader.MovementEvent += OnMovement;
    }

    void Update()
    {
        transform.Translate(movement * Time.deltaTime);
    }

    private void OnMovement(Vector2 newMovement)
    {
        movement = newMovement * speed;
    }
}