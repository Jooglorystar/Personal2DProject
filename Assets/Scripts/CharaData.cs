using System;
using UnityEngine;

[Serializable]
public class CharaData
{
    public string charaName = "Default";
    [Range(1f, 10f)] public float charaSpeed;
}
