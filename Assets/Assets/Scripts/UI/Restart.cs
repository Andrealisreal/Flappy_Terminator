using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    [RequireComponent(typeof(Button))]
    public class Restart : MonoBehaviour
    {
        [SerializeField] private SceneLoader _sceneLoader;
        
        private Button _button;
        
        private void Awake() =>
            _button = GetComponent<Button>();

        private void OnEnable() =>
            _button.onClick.AddListener(_sceneLoader.ReloadScene);
        
        private void OnDisable() =>
            _button.onClick.RemoveListener(_sceneLoader.ReloadScene);
    }
}
