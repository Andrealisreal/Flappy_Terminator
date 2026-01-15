using Assets.Scripts.Players;
using Assets.Scripts.Players.Bullets;
using UnityEngine;

namespace Assets.Scripts
{
    [RequireComponent(typeof(PlayerSpawnerBullet))]
    public class Game : MonoBehaviour
    {
        [SerializeField] private Player _player;
        
        private PlayerSpawnerBullet _playerSpawnerBullet;

        private void Awake()
        {
            _playerSpawnerBullet = GetComponent<PlayerSpawnerBullet>();
            
            _player.InitializeSpawner(_playerSpawnerBullet);
        }
    }
}
