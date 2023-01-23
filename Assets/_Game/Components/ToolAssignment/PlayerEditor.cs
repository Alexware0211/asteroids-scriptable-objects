using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AsteroidSettings))]
public class PlayerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        var style = new GUIStyle(GUI.skin.label) { alignment = TextAnchor.MiddleCenter };
        GUILayout.Label("Player Settings", style, GUILayout.ExpandWidth(true));

        PlayerSettings player = target as PlayerSettings;
        player.PHealth = EditorGUILayout.IntSlider("Health: ", player.PHealth, 0, 100);
        player.Speed = EditorGUILayout.Slider("Speed: ", player.Speed, 0.1f, 5f);

    }
}
