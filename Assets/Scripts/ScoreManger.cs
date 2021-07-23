using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManger : MonoBehaviour
{
    public TMP_Text score_text;
    int score;

    void Start()
    {
        score = 0;
        score_text.text = "Score: " + score.ToString();
    }

    public void incrementScore(int value)
    {
        score += value;
        score_text.text = "Score: " + score.ToString();
    }

    public void decrementScore(int value)
    {
        score -= value;
        score_text.text = "Score: " + score.ToString();
    }
}