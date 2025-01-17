using UnityEngine;

namespace GameScripts.UI
{
    internal abstract class Window
    {
        private WindowController controller;

        public Window(WindowController controller)
        {
            this.controller = controller;
        }

        public Window(GameObject gameObject)
        {
            controller = new(gameObject);
        }

        protected void ShowWindow()
        {
            controller.ActivateWindow();
        }

        protected void HideWindow()
        {
            controller.DeactivateWindow();
        }
    }
}