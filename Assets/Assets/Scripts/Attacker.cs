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
        protected Spawner<T> Spawner;
        
        private bool _isAttacking;
    
        private void Awake() =>
            Wait = new WaitForSeconds(Delay);

        public void Initialize(Spawner<T> spawner) =>
            Spawner = spawner;
        
        public virtual void Attack()
        {
            if (_isAttacking)
                return;
            
            var item = Spawner.Spawn(transform);
            
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
