using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : Singleton<UI>
{
    public Text ScoreText;

    public Image[] LifeImages;


    public GameObject StartGameScreen;

    public Text GameScoreText;

    public int Score=0;

    private void Start()
    {
        ScoreText.text = "Score: "+Score;
    }

    public void ChangeScore(int ScoreChange)
    {
        Score += ScoreChange;

        ScoreText.text = "Score: " + Score;
        GameScoreText.text = "Score: " + Score; 
    }

    void Update()
    {
        for (int i = 0; i < LifeImages.Length; i++)
        {
            if (i >= GameManager.Instance.Lives)
            {
                LifeImages[i].gameObject.SetActive(false);
            }
            else
            {
                LifeImages[i].gameObject.SetActive(true);
            }
        }
    }

}
