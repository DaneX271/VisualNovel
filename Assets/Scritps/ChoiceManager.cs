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
    public Button ButtonNext;
    public Button NextChoice1;
    public Button NextChoice2;


    void Start()
    {
        UpdateChoice( CurrentChoice );
    }

    void UpdateChoice ( Choice choice )
    {
        if(choice.NextChoice1 == null)
        {
            ButtonNext.interactable = false;
        }

        if(choice.HasAChoice == false)
        {
            NextChoice1.gameObject.SetActive(false);
            NextChoice2.gameObject.SetActive(false);
            ButtonNext.gameObject.SetActive(true);
        }

        else
        {
            NextChoice1.gameObject.SetActive(true);
            NextChoice2.gameObject.SetActive(true);
            ButtonNext.gameObject.SetActive(false);
        }

        BackgroundImage.sprite = choice.BackgroundSprite;
        CharacterImage.sprite = choice.CharacterSprite;
        TitleText.text = choice.TitleText;
        DialogText.text = choice.DialogText;
    }

    public void OnClickNextDialog1()
    {
        CurrentChoice = CurrentChoice.NextChoice1;
        UpdateChoice ( CurrentChoice );
    }

    public void OnClickNextDialog2()
    {
        CurrentChoice = CurrentChoice.NextChoice2;
        UpdateChoice ( CurrentChoice );
    }


}
