using System;
using System.Collections;
using Assets.Scripts.Enemies.Bullets;
using Assets.Scripts.Generics.Spawners;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Assets.Scripts.Enemies
{
    public class EnemySpawner : Spawner<Enemy>
    {
        [SerializeField] private EnemySpawnerBullet _bulletSpawner;
        [SerializeField] private Transform[] _points;
        [SerializeField] private float _delay = 2f;
        
        private WaitForSeconds _wait;
        private Coroutine _currentRoutine;

        public event Action<Enemy> Disabled;

        private void Awake() =>
            _wait = new WaitForSeconds(_delay);
        
        private void Start() =>
            _currentRoutine = StartCoroutine(SpawnRoutine());
        
        private void OnDisable() =>
            StopCoroutine(_currentRoutine);
        
        private IEnumerator SpawnRoutine()
        {
            while (enabled)
            {
                var enemy = Spawn(_points[Random.Range(0, _points.Length)].transform);
                enemy.Attacker.Initialize(_bulletSpawner);
                enemy.Disabled += OnDisabled;
                
                yield return _wait;
            }
        }

        private void OnDisabled(Enemy enemy)
        {
            Disabled?.Invoke(enemy);
            enemy.Disabled -= OnDisabled;
        }
    }
}
