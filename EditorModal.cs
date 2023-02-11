//Author: https://github.com/seekeroftheball    https://gist.github.com/seekeroftheball
//Version: 1.0
//Date: Feb 2023

using UnityEditor;
using UnityEngine;

namespace EditorModal
{
    public class EditorPopupModal : EditorWindow
    {
        private struct WindowBounds
        {
            public const float WindowWidth = 242;
            public const float WindowHeight = 72;

            public static Vector2 WindowSize = new(WindowWidth, WindowHeight);
        }

        private EditorPopupModal()
        {
            minSize = WindowBounds.WindowSize;
            maxSize = WindowBounds.WindowSize;
        }

        private void OnGUI() => DrawWindow();

        private void OnInspectorUpdate() => Repaint();

        private void DrawWindow()
        {
            GUILayout.Label("Here's some text in a pop-up window.\n\nPress Close to dismiss this message.", EditorStyles.wordWrappedLabel);

            if (GUILayout.Button("Close"))
                Close();
        }
    }
}
