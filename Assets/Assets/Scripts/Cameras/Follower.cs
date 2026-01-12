using UnityEngine;

namespace Assets.Scripts.Cameras
{
    public class Follower : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] private Vector2 _offset;

        private void LateUpdate()
        {
            Follow();
        }

        private void Follow()
        {
            transform.position = new Vector2(_target.position.x + _offset.x, transform.position.y);
        }
    }
}
