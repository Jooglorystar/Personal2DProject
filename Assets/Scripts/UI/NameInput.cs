using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NameInput : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI inputPlayerName;
    [SerializeField] private CharaDataHandler charaData;
    [SerializeField] private GameObject Player;

    public void FinishButton()
    {
        Player.SetActive(true);
        charaData.CurrentData.dataSO.charaName = inputPlayerName.text;
        CharaList.CharaNames.Add(charaData.CurrentData.dataSO.charaName);
        GameManager.Instance.isPause = false;
        this.gameObject.SetActive(false);
    }

    public void OpenNameEdit()
    {
        GameManager.Instance.isPause = true;
        Player.SetActive(false);
        CharaList.CharaNames.Remove(charaData.CurrentData.dataSO.charaName);
        this.gameObject.SetActive(true);
    }
}
