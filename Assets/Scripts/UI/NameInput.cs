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
        GameManager.instance.isPause = false;
        this.gameObject.SetActive(false);
    }

    public void OpenNameEdit()
    {
        GameManager.instance.isPause = true;
        this.gameObject.SetActive(true);
    }
}
