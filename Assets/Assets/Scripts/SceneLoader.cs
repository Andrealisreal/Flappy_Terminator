using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class SceneLoader : MonoBehaviour
    {
        public void LoadSceneGame() =>
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
