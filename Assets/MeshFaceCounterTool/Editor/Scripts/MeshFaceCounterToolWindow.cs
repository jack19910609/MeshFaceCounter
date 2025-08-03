using UnityEditor;
using UnityEngine;

namespace MeshFaceCounterTool
{
    public class MeshFaceCounterToolWindow : EditorWindow
    {
        [MenuItem("Tools/MeshFaceCounterTool")]
        public static void ShowWindow()
        {
            GetWindow(typeof(MeshFaceCounterToolWindow) , true , "Mesh Face Counter", true);
        }

        void OnGUI()
        {
            GUILayout.Label("Count triangle faces in selected 3D assets", EditorStyles.boldLabel);

            if (GUILayout.Button("Count Faces in Selected Folder"))
            {
                
            }
        }
    }
}