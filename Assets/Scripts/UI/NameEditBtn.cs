using UnityEngine;

public class NameEditBtn : MonoBehaviour
{
    [SerializeField] private NameEdit nameEdit;
    [SerializeField] private GameObject nameEditPanel;

    private bool isOpen = false;

    public void NameEditButton()
    {
        if (!isOpen)
        {
            OpenNameEdit();
        }
        else
        {
            CloseNameEdit();
        }
    }

    void OpenNameEdit()
    {
        isOpen = true;
        GameManager.Instance.isPause = true;
        nameEditPanel.SetActive(true);

    }

    void CloseNameEdit()
    {
        isOpen = false;
        GameManager.Instance.isPause = false;
        nameEditPanel.SetActive(false);
    }

    public void SetCharaName()
    {
        nameEdit.SetCharaName();
        CloseNameEdit();
    }
}
