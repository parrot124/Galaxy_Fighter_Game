using UnityEngine.InputSystem;
using UnityEngine;
using Zenject;
using System;

namespace GameScripts.Input
{
    public class InputReader
    {
        public event Action<Vector2> MovementEvent;
        public event Action<bool> ShootEvent;

        private CustomInput customInput;

        [Inject]
        public InputReader(CustomInput input)
        {
            customInput = input;
            customInput.Enable();

            customInput.Gameplay.Movement.performed += OnMovement;
            customInput.Gameplay.Shoot.performed += OnShoot;
            customInput.Gameplay.Shoot.canceled += OnShoot;
            customInput.Gameplay.Movement.canceled += OnMovement;
        }

        private void OnShoot(InputAction.CallbackContext context)
        {
            var value = context.ReadValue<float>();
            ShootEvent?.Invoke(value == 1.0f);

            if (value != 0.0f) Debug.Log("Shooting");
            if (value == 0.0f) Debug.Log("Release");
        }

        public void Disable()
        {
            customInput.Gameplay.Movement.performed -= OnMovement;
            customInput.Gameplay.Shoot.performed -= OnShoot;
            customInput.Gameplay.Shoot.canceled -= OnShoot;
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
