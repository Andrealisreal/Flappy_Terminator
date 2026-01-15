using Assets.Scripts.Enemies;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.UI
{
    public class Score : MonoBehaviour
    {
        [SerializeField] private EnemySpawner _enemySpawner;
        [SerializeField] private TextMeshProUGUI _scoreText;

        private int _score;

        private void OnEnable() =>
            _enemySpawner.Disabled += UpdateScore;

        private void OnDisable() =>
            _enemySpawner.Disabled -= UpdateScore;

        private void UpdateScore(Enemy enemy)
        {
            _score++;
            _scoreText.text = $"{_score}";
        }
    }
}