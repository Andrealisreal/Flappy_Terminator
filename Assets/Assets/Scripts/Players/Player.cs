using Assets.Scripts.Interfaces;
using Assets.Scripts.Players.Bullets;
using Assets.Scripts.Players.Input;
using Assets.Scripts.Players.Movement;
using UnityEngine;

namespace Assets.Scripts.Players
{
    [RequireComponent(typeof(PlayerInput))]
    [RequireComponent(typeof(Jumper))]
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(CircleCollider2D))]
    public class Player : MonoBehaviour, IDamageable
    {
        [SerializeField] private PlayerAttacker _attacker;
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
            _input.AttackClicked += _attacker.Attack;
        }

        private void OnDisable()
        {
            _input.JumpClicked -= _jumper.Jump;
            _input.AttackClicked -= _attacker.Attack;
        }

        public void InitializeSpawner(PlayerSpawnerBullet bullet) =>
            _attacker.Initialize(bullet);

        public void Die()
        {
            Time.timeScale = 0f;
            Time.fixedDeltaTime = 0f;
        }
    }
}
