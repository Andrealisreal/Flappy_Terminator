using Assets.Scripts.Players;
using UnityEngine;

namespace Assets.Scripts.UI
{
    public class GameOver : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private GameObject _gameOverUI;

        private void OnEnable()
        {
            _player.Died += OnPlayerDied;
        }

        private void OnDisable()
        {
            _player.Died -= OnPlayerDied;
        }

        private void OnPlayerDied()
        {
            Time.timeScale = 0f;
            Time.fixedDeltaTime = 0f;
            _gameOverUI.SetActive(true);
        }
    }
}