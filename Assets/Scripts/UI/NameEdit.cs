using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NameEdit : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI inputPlayerName;
    [SerializeField] private CharaDataHandler charaData;
    [SerializeField] private DisplayCharaName displayCharaName;

    public void SetCharaName()
    {
        string oldName = charaData.CurrentData.dataSO.charaName;

        if (CharaList.CharaNames.Contains(oldName))
        {
            CharaList.RemoveCharacterList(oldName);
        }
        charaData.CurrentData.dataSO.charaName = inputPlayerName.text;
        CharaList.AddCharacterList(charaData.CurrentData.dataSO.charaName);
        displayCharaName.ResetPlayerName();
    }
}
