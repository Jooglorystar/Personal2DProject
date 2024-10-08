using UnityEngine;

public class CharaDataHandler : MonoBehaviour
{
    [SerializeField] private CharaData baseData;
    public CharaData CurrentData { get; set; }

    private void Awake()
    {
        UpdateCharacterData();
    }

    private void UpdateCharacterData()
    {
        CurrentData = new CharaData();
        CurrentData.charaName = baseData.charaName;
        CurrentData.charaSpeed = baseData.charaSpeed;
    }
}