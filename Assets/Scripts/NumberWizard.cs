using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI guessText;
    int guess; 

    void Start()
    {
        setNextGuess();
        max = max + 1;
    }

    void setNextGuess() {
        guess = (max + min) /2; 
        guessText.text = guess.ToString();
    }

    public void onHigherPressed() {
        min = guess;
        setNextGuess();
    }

    public void onLowerPressed() {
        max = guess;
        setNextGuess();
    }

}
