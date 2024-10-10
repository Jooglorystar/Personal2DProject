using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class CharaList : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI CharaListText;
    static public List<string> CharaNames = new List<string>();

    public void WriteCharaNames()
    {
        StringBuilder sb = new StringBuilder();

        if (CharaNames.Count > 0)
        {
            for (int i = 0; i < CharaNames.Count; i++)
            {
                sb.Append(CharaNames[i]);
                sb.Append("\n");
            }
        }
        else
        {
            sb.Append("아무도 없습니다.");
        }
        string result = sb.ToString();
        CharaListText.text = result;
    }
}
