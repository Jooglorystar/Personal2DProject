using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Conversation : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject ConversationPanel;
    [SerializeField] TextMeshProUGUI CharaNameText;
    CharaDataHandler charaData;

    private void Start()
    {
        ConversationPanel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        charaData = this.GetComponentInParent<CharaDataHandler>();

        if (collision.gameObject == Player)
        {
            ConversationPanel.SetActive(true);
            CharaNameText.text = charaData.CurrentData.dataSO.charaName;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == Player)
        {
            ConversationPanel.SetActive(false);
        }
    }
}