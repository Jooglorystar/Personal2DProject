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
        CharaDataSO dataSO = null;
        if (baseData.dataSO != null)
        {
            dataSO = Instantiate(baseData.dataSO);
        }

        CurrentData = new CharaData { dataSO = dataSO };
        //CurrentData.dataSO = dataSO;
    }
}