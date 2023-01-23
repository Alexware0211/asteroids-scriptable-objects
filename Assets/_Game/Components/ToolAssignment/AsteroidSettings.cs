using System.Collections;
using System.Collections.Generic;
using UnityEngine;

   [CreateAssetMenu(fileName = "Asteroid", menuName = "Asteroid", order = 0)]
public class AsteroidSettings : ScriptableObject
{

    [Range(0, 100)]
    public int Damage = 1;
    public Color Color = Color.red;

    [Range(0, 100)]
    public float Size = 1;

    [Range(0, 100)]
    public float Speed = 1;

}
