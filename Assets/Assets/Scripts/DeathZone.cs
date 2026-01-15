using UnityEngine;

namespace Assets.Scripts
{
    public class DeathZone : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log(other.name);
            other.gameObject.SetActive(false);
        }
    }
}
