using UnityEngine;
using Zenject;

public class PlayerController : MonoBehaviour
{
    [Inject] private InputReader _inputReader;

    private Vector2 movement;
    [SerializeField] private float speed;

    void Start()
    {
        movement = Vector2.zero;
        _inputReader.MovementEvent += OnMovement;
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