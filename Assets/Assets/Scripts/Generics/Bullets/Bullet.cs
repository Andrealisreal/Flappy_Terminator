using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Generics.Bullets
{
    public abstract class Bullet : MonoBehaviour, IDirectional
    {
        [SerializeField] protected float Speed;

        public void SetDirection(Vector2 direction) =>
            transform.right = direction.normalized;
        
        private void Update() =>
            transform.position += transform.right * (Speed * Time.deltaTime);
    }
}
