using System;
using Assets.Scripts.Generics.Objects;
using UnityEngine;

namespace Assets.Scripts.Generics.Spawners
{
    public abstract class Spawner<T> : MonoBehaviour where T : Component
    {
        [SerializeField] protected ObjectsPool<T> ObjectsPool;

        private int _numberSpawnedObjects;
        
        public event Action<int> Spawned;
        
        public virtual T Spawn()
        {
            _numberSpawnedObjects++;
            Spawned?.Invoke(_numberSpawnedObjects);
            return ObjectsPool.GetObject();
        }
    }
}
