using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Level Settings")]
public class LevelSettings : ScriptableObject
{
    public Color32 backgroundColor = Color.white;
    public float gravity = 9.81f;
}
