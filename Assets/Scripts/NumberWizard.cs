using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI guessText;
    [SerializeField] TextMeshProUGUI guessCountText;
    int guess; 
    int guessCount = 0;

    void Start()
    {
        setNextGuess();
        guessCount = 0;
    }

    void setNextGuess() {
        guess = Random.Range(min, max+1); 
        guessText.text = guess.ToString();
        guessCount++;
        guessCountText.text = $"It took me {guessCount} guesses to find your anwser!";
    }

    public void onHigherPressed() {
        min = guess + 1;
        setNextGuess();
    }

    public void onLowerPressed() {
        max = guess - 1;
        setNextGuess();
    }

}
