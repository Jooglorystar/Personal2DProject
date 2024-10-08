using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayCharaName : MonoBehaviour
{
    public TextMeshProUGUI playerName;
    public CharaDataHandler charaData;

    void Start()
    {
        ResetPlayerName();
    }

    public void ResetPlayerName()
    {
        playerName.text = charaData.CurrentData.charaName;
    }
}
