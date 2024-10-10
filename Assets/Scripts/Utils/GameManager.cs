using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Transform Player {  get; private set; }
    public bool isPause = true;

    [SerializeField]private CharaList charaList;

    public void Awake()
    {
        if(Instance == null )
        {
            Instance = this;
        }
        
        charaList = GetComponent<CharaList>();
    }

    public void Start()
    {
        GameObject[] characters = GameObject.FindGameObjectsWithTag("Character");

        if (characters.Length > 0)
        {
            foreach (GameObject character in characters)
            {
                CharaDataHandler charaData = character.GetComponent<CharaDataHandler>();
                CharaList.AddCharacterList(charaData.CurrentData.dataSO.charaName);
            }
        }
        else
        {
            Debug.Log("Nothing!");
        }
    }
}
