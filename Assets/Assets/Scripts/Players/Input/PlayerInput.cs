using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Scripts.Players.Input
{
    public class PlayerInput : MonoBehaviour
    {
        public event Action JumpClicked;
        public event Action AttackClicked;

        private InputActions _inputAction;

        private void Awake()
        {
            _inputAction = new InputActions();

            _inputAction.Player.Jump.performed += Jump;
            _inputAction.Player.Attack.performed += Attack;
        }

        private void OnEnable() =>
            _inputAction.Enable();

        private void OnDisable() =>
            _inputAction.Disable();

        private void Jump(InputAction.CallbackContext context) =>
            JumpClicked?.Invoke();
        
        private void Attack(InputAction.CallbackContext context) =>
            AttackClicked?.Invoke();
    }
}
