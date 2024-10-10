using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaListBtn : MonoBehaviour
{
    [SerializeField] private GameObject CharaListPanel;
    [SerializeField] private CharaList charaList;

    private bool isOpen = false;
    
    public void CharaListButton()
    {
        if (!isOpen)
        {
            OpenList();
        }
        else
        {
            CloseList();
        }
    }

    void OpenList()
    {
        isOpen = true;
        CharaListPanel.SetActive(true);
        charaList.WriteCharaNames();
        
    }

    void CloseList()
    {
        isOpen = false;
        CharaListPanel.SetActive(false);
    }
}
