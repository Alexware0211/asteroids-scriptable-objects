using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSettings", menuName = "PlayerSettings", order = 0)]
public class PlayerSettings : ScriptableObject
{


    [Range(0, 100)]
    public int PHealth = 100;

    [Range(0, 100)]
    public float Speed = 1;

}
