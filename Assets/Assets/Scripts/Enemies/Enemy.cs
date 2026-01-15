using System;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Enemies
{
    public class Enemy : MonoBehaviour, IDamageable
    {
        [field: SerializeField] public EnemyAttacker Attacker  { get; private set; }

        public event Action<Enemy> Disabled;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.TryGetComponent(out IDamageable damageable))
                damageable.Die();
        }

        public void Die()
        {
            Disabled?.Invoke(this);
            gameObject.SetActive(false);
        }
    }
}
