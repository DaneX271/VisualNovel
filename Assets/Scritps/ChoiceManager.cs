using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChoiceManager : MonoBehaviour
{
    public Choice CurrentChoice;
    public Image BackgroundImage;
    public Image CharacterImage;
    public TextMeshProUGUI TitleText;
    public TextMeshProUGUI DialogText;


    void Start()
    {
        BackgroundImage.sprite = CurrentChoice.BackgroundSprite;
        CharacterImage.sprite = CurrentChoice.CharacterSprite;
        TitleText.text = CurrentChoice.TitleText;
        DialogText.text = CurrentChoice.DialogText;
    }


}
