using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharaCreate : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI inputPlayerName;
    [SerializeField] private CharaDataHandler charaData;
    [SerializeField] private GameObject Player;

    public void FinishCharaCreate()
    {
        Player.SetActive(true);
        charaData.CurrentData.dataSO.charaName = inputPlayerName.text;
        CharaList.AddCharacterList(charaData.CurrentData.dataSO.charaName);
        GameManager.Instance.isPause = false;
        this.gameObject.SetActive(false);
    }
}
