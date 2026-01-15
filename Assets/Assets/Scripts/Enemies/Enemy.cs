using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Enemies
{
    public class Enemy : MonoBehaviour, IDamageable
    {
        [field: SerializeField] public EnemyAttacker Attacker  { get; private set; }
        
        public void Die()
        {
            gameObject.SetActive(false);
        }
    }
}
