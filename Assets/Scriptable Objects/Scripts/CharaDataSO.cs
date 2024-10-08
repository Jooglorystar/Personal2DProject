using UnityEngine;

[CreateAssetMenu(fileName = "CharaDataSO", menuName = "Project/CharaData/Default", order = 0)]
public class CharaDataSO : ScriptableObject
{
    [Header("Character Data")]
    public string charaName;
    public float charaSpeed;
}
