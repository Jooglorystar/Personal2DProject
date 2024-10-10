using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UIElements;

public class CharaSelectBtn : MonoBehaviour
{
    [SerializeField] private SpriteRenderer playerSprite;
    [SerializeField] private Animator playerAnimator;

    [SerializeField] private GameObject knight01Panel;
    [SerializeField] private GameObject knight02Panel;
    [SerializeField] private GameObject Elf01Panel;

    [SerializeField] private Sprite knight01Image;
    [SerializeField] private Sprite knight02Image;
    [SerializeField] private Sprite Elf01Image;    
    
    [SerializeField] private AnimatorController knight01Controller;
    [SerializeField] private AnimatorController knight02Controller;
    [SerializeField] private AnimatorController Elf01Controller;

    void Start()
    {
        Knight01Select();
    }

    public void Knight01Select()
    {
        playerSprite.sprite = knight01Image;
        playerAnimator.runtimeAnimatorController = knight01Controller;
        knight01Panel.SetActive(true);
        knight02Panel.SetActive(false);
        Elf01Panel.SetActive(false);
    }

    public void Knight02Select()
    {
        playerSprite.sprite = knight02Image;
        playerAnimator.runtimeAnimatorController = knight02Controller;
        knight01Panel.SetActive(false);
        knight02Panel.SetActive(true);
        Elf01Panel.SetActive(false);
    }

    public void Elf01Select()
    {
        playerSprite.sprite = Elf01Image;
        playerAnimator.runtimeAnimatorController = Elf01Controller;
        knight01Panel.SetActive(false);
        knight02Panel.SetActive(false);
        Elf01Panel.SetActive(true);
    }
}
