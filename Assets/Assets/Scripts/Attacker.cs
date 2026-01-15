using System.Collections;
using Assets.Scripts.Generics.Spawners;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts
{
    public abstract class Attacker<T> : MonoBehaviour where T : Component, IDirectional
    {
        [SerializeField] protected float Delay = 0.5f;
    
        protected WaitForSeconds Wait;
        
        private Spawner<T> _spawner;
        
        private bool _isAttacking;
    
        private void Awake() =>
            Wait = new WaitForSeconds(Delay);

        public void Initialize(Spawner<T> spawner) =>
            _spawner = spawner;
        
        public void Attack()
        {
            if (_isAttacking)
                return;
            
            var item = _spawner.Spawn(transform);
            
            item.SetDirection(GetDirection());
            
            StartCoroutine(CooldownAttack());
        }

        
        protected virtual Vector2 GetDirection() =>
            transform.right;
        
        protected virtual IEnumerator CooldownAttack()
        {
            _isAttacking = true;
            
            yield return Wait;
            
            _isAttacking = false;
        }
    }
}
