using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choice : MonoBehaviour
{
    public string TitleText;
    public string DialogText;
    public string ChoiceText1;
    public string ChoiceText2;
    public Sprite CharacterSprite;
    public Sprite BackgroundSprite;
    public Choice NextChoice1;
    public Choice NextChoice2;
    public bool HasAChoice;
}
