using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class SceneLoader : MonoBehaviour
    {
        public void LoadSceneGame() =>
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        public void ReloadScene()
        {
            Time.timeScale = 1f;
            Time.fixedDeltaTime = 0.02f;
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
