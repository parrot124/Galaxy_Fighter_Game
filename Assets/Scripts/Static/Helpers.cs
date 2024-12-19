using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameScripts.Static
{
    internal static class Helpers
    {
        public static Dictionary<string, Button.ButtonClickedEvent> MainMenuButtonEventsDict = new();

        public static class GameHelper
        {
            public static GameObject PlayerGameObject
            {
                get
                {
                    if (playerGameObject == null)
                    {
                        playerGameObject = GameObject.FindGameObjectWithTag(GameConstants.PlayerTag);
                    }

                    return playerGameObject;
                }

                private set
                {
                    playerGameObject = value;
                }
            }

            public static GameObject CanvasGameObject
            {
                get
                {
                    if (canvasGameObject == null)
                    {
                        canvasGameObject = GameObject.FindGameObjectWithTag(GameConstants.UITag);
                    }

                    return canvasGameObject;
                }
            }

            private static GameObject canvasGameObject;
            private static GameObject playerGameObject;
        }
    }
}
