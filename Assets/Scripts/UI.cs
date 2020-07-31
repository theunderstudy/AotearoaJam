using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : Singleton<UI>
{
    public Text ScoreText;
    private int Score=0;

    private void Start()
    {
        ScoreText.text = "Score: "+Score;
    }

    public void ChangeScore(int ScoreChange)
    {
        Score += ScoreChange;

        ScoreText.text = "Score: " + Score;
    }
}
