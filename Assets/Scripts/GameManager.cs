using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{

    public bool bGameRunning = false;

    public Player player;

    public int Lives = 3;

    public AudioSource Audio;

    public AudioClip DeathSound;
    public void StartGame()
    {
        bGameRunning = true;
        Lives = 3;

        player.transform.position = Vector3.zero;
        UI.Instance.StartGameScreen.SetActive(false);
    }


    public void EndGame()
    {
        bGameRunning = false;
        Lives = 3;

        player.transform.position = Vector3.zero;

        UI.Instance.StartGameScreen.SetActive(true);
        Audio.PlayOneShot(DeathSound);
    }


    void Update()
    {
        if (Lives == 0)
        {
            EndGame();
        }
    }
}
