using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Conversation : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject ConversationPanel;
    [SerializeField] TextMeshProUGUI CharaNameText;
    public CharaDataHandler charaData;
    ConversationStart conversationStart;

    public bool isTalking;

    private void Awake()
    {
        charaData = this.GetComponentInParent<CharaDataHandler>();
        conversationStart = GetComponent<ConversationStart>();
    }

    private void Start()
    {
        ConversationPanel.SetActive(false);
        isTalking = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Player)
        {
            ConversationPanel.SetActive(true);
            CharaNameText.text = charaData.CurrentData.dataSO.charaName;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == Player && ConversationPanel)
        {
            ConversationPanel.SetActive(false);
        }
        if (isTalking)
        {
            conversationStart.EndConversation();
        }
    }
}