using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaListBtn : MonoBehaviour
{
    [SerializeField] private GameObject CharaListPanel;

    private bool isOpen = false;
    private CharaList charaList;

    public void Awake()
    {
        charaList = CharaListPanel.GetComponent<CharaList>();
    }

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
