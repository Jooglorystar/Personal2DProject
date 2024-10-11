using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaEditBtn : MonoBehaviour
{
    [SerializeField] private GameObject CharaEditPanel;

    private bool isOpen = false;

    public void CharaEditButton()
    {
        if (!isOpen)
        {
            OpenCharaEdit();
        }
        else
        {
            CloseCharaEdit();
        }
    }

    void OpenCharaEdit()
    {
        isOpen = true;
        GameManager.Instance.isPause = true;
        CharaEditPanel.SetActive(true);

    }

    void CloseCharaEdit()
    {
        isOpen = false;
        GameManager.Instance.isPause = false;
        CharaEditPanel.SetActive(false);
    }
}
