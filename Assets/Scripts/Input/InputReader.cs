using UnityEngine.InputSystem;
using UnityEngine;
using Zenject;
using System;

namespace GameScripts.Input
{
    public class InputReader
    {
        public event Action<Vector2> MovementEvent;
        public event Action ShootEvent;

        private CustomInput customInput;

        [Inject]
        public InputReader(CustomInput input)
        {
            customInput = input;
            Debug.Log("InputReader Constructed");
            customInput.Enable();

            customInput.Gameplay.Movement.performed += OnMovement;
            customInput.Gameplay.Shoot.performed += OnShootStarted;
            customInput.Gameplay.Shoot.canceled += OnShootStarted;
            customInput.Gameplay.Movement.canceled += OnMovement;
        }

        private void OnShootStarted(InputAction.CallbackContext context)
        {
            int value = context.ReadValue<int>();
            ShootEvent?.Invoke();
        }

        public void Disable()
        {
            customInput.Gameplay.Movement.performed -= OnMovement;
            customInput.Gameplay.Shoot.performed -= OnShootStarted;
            customInput.Gameplay.Shoot.canceled -= OnShootStarted;
            customInput.Gameplay.Movement.canceled -= OnMovement;

            MovementEvent?.Invoke(Vector2.zero);
        }

        private void OnMovement(InputAction.CallbackContext context)
        {
            Vector2 movement = context.ReadValue<Vector2>();
            MovementEvent?.Invoke(movement);
        }
    }
}
