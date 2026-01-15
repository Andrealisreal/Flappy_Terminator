using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts
{
    public class DeathZone : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.TryGetComponent(out IDamageable damageable))
                damageable.Die();
            else
                other.gameObject.SetActive(false);
        }
    }
}
