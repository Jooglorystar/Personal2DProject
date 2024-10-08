using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NameInput : MonoBehaviour
{
    public TextMeshProUGUI inputPlayerName;
    public CharaDataHandler charaData;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FinishButton()
    {
        charaData.CurrentData.charaName = inputPlayerName.text;
        GameManager.instance.isPause = false;
        this.gameObject.SetActive(false);
    }

    public void OpenNameEdit()
    {
        GameManager.instance.isPause = true;
        this.gameObject.SetActive(true);
    }
}
