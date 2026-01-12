using Assets.Scripts.Players.Input;
using Assets.Scripts.Players.Movement;
using UnityEngine;

namespace Assets.Scripts.Players
{
    [RequireComponent(typeof(PlayerInput))]
    [RequireComponent(typeof(Jumper))]
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(CircleCollider2D))]
    public class Player : MonoBehaviour
    {
        private PlayerInput _input;
        private Jumper _jumper;
        
        private void Awake()
        {
            _input = GetComponent<PlayerInput>();
            _jumper = GetComponent<Jumper>();
        }

        private void OnEnable()
        {
            _input.JumpClicked += _jumper.Jump;
        }

        private void OnDisable()
        {
            _input.JumpClicked -= _jumper.Jump;
        }
    }
}
