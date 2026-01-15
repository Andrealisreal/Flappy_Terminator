using Assets.Scripts.Generics.Objects;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Generics.Spawners
{
    public abstract class Spawner<T> : MonoBehaviour, IProjectileSpawner<T> where T : Component
    {
        [SerializeField] protected ObjectsPool<T> ObjectsPool;
        
        public T Spawn(Transform point)
        {
            var item = ObjectsPool.GetObject();
            
            item.transform.position = point.position;

            return item;
        }
    }
}
