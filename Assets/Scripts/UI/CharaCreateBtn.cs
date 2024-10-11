using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaCreateBtn : MonoBehaviour
{
    [SerializeField]CharaCreate charaCreate;

    public void FinishCharaCreate()
    {
        charaCreate.FinishCharaCreate();
    }
}
