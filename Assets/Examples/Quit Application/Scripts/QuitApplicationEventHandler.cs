using UnityEngine;
using UnityEngine.UIElements;

namespace DDStudio.CORE
{
    [RequireComponent(typeof(UIDocument))]
    public class QuitApplicationEventHandler : MonoBehaviour
    {
        private Button _quitApplicationButton;

        private void Start()
        {
            var rootElement = gameObject.GetComponent<UIDocument>().rootVisualElement;

            _quitApplicationButton = rootElement.Q<Button>("QuitApplicationButton");

            if (_quitApplicationButton != null)
            {
                // Buttons can register callBacks with clickable.clicked
                _quitApplicationButton.clickable.clicked += OnQuitApplicationButtonClicked;
            }
        }

        private void OnDestroy()
        {
            _quitApplicationButton.clickable.clicked -= OnQuitApplicationButtonClicked;
        }

        private void OnQuitApplicationButtonClicked()
        {
            print("You clicked on the Quit Application button, and therefor the application will now quit, duh!");

            ApplicationHandler.QuitApplication();
        }
    }
}
