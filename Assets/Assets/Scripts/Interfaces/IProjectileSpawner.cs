using UnityEngine;

namespace Assets.Scripts.Interfaces
{
    public interface IProjectileSpawner<out T> where T : Component
    {
        T Spawn(Transform spawnPoint);
    }
}
