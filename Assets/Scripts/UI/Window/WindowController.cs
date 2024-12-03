using UnityEngine;

namespace Assets.Scripts.UI
{
    internal class WindowController
    {
        private GameObject window;

        public WindowController(GameObject windowObject)
        {
            window = windowObject;
        }

        public void ActivateWindow()
        {
            window.SetActive(true);
        }

        public void DeactivateWindow()
        {
            window.SetActive(false);
        }
    }
}
