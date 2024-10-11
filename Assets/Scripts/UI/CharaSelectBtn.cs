using UnityEngine;

public class CharaSelectBtn : MonoBehaviour
{
    private CharaSelect charaSelect;

    private void Awake()
    {
        charaSelect = GetComponent<CharaSelect>();
    }

    public void Knight01SelectButton()
    {
        charaSelect.Knight01Select();
    }

    public void Knight02SelectButton()
    {
        charaSelect.Knight02Select();
    }

    public void Elf01SelectButton()
    {
        charaSelect.Elf01Select();
    }
}