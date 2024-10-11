using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TimeTxt;

    void Start()
    {
        
    }

    void Update()
    {
        TimeTxt.text = SetTime();
    }

    string SetTime()
    {
        return DateTime.Now.ToString("HH:mm");
    }
}
