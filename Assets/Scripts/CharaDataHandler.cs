using UnityEngine;

public class CharaDataHandler : MonoBehaviour
{
    [SerializeField] private CharaData baseData;
    public CharaData CurrentData { get; private set; }

    private void Awake()
    {
        UpdateCharacterData();
    }

    private void UpdateCharacterData()
    {
        CurrentData.charaName = baseData.charaName;
        CurrentData.charaSpeed = baseData.charaSpeed;
    }
}