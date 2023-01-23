using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AsteroidSettings))]
public class AsteroidEditor : Editor
{
    public override void OnInspectorGUI()
    {
        var style = new GUIStyle(GUI.skin.label) { alignment = TextAnchor.MiddleCenter };
        GUILayout.Label("Asteroid Editor", style, GUILayout.ExpandWidth(true));

        AsteroidSettings asteroid = target as AsteroidSettings;
        asteroid.Damage = EditorGUILayout.IntSlider("Damage: ", asteroid.Damage, -10, 100);
        asteroid.Color = EditorGUILayout.ColorField("Color: ", asteroid.Color);
        asteroid.Size = EditorGUILayout.Slider("Size: ", asteroid.Size, 0.1f, 5f);
        asteroid.Speed = EditorGUILayout.Slider("Speed: ", asteroid.Speed, 0.1f, 5f);

    }
}
