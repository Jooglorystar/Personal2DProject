using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;

public class ConversationStart : MonoBehaviour
{
    private Conversation conversation;
    [SerializeField]private GameObject conversationBubble;
    [SerializeField] private TextMeshProUGUI TalkerName;
    [SerializeField] private TextMeshProUGUI TalkerDescription;

    private void Awake()
    {
        conversation = this.GetComponent<Conversation>();
    }

    private void Start()
    {
        conversationBubble.SetActive(false);
    }

    public void StartConversation()
    {
        TalkerName.text = conversation.charaData.CurrentData.dataSO.charaName;
        TalkerDescription.text = $"¿Ö ³¯ ºÒ·¶Áö?";
        conversation.isTalking = true;
        conversationBubble.SetActive(true);
    }

    public void EndConversation()
    {
        conversation.isTalking = false;
        conversationBubble.SetActive(false);
    }
}
