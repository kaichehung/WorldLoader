using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor((typeof(WorldLoaderScript)))]
public class WorldLoaderEditor : Editor {

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        WorldLoaderScript inspectorScript = (WorldLoaderScript) target;
        if (GUILayout.Button("Load Scene"))
        {
            inspectorScript.LoadScene();
        }

    }

}
