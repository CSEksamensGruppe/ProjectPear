using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject Player;
    public GameObject WinScreen;
    public GameObject DeadScreen;
    public ScoreSystem Score;

    private bool deadScreenSpawned = false;
    private bool winScreenSpawned = false;

    void Update()
    {
        PlayerDead();
    }

    public void LoadNextLevel()
    {
        int nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextLevel);
    }

    public void WinGame()
    {
        Score.StopTimer();
        Time.timeScale = 0f;
        Debug.Log("Game is done");
        //TODO: Spawn win-screen.
        Instantiate(WinScreen, new Vector3(0, 0, 0), Quaternion.identity);
    }

    public void PlayerDead()
    {
        if (!Player && !deadScreenSpawned)
        {
            Instantiate(DeadScreen, new Vector3(0, 0, 0), Quaternion.identity);
            deadScreenSpawned = true;
            if (!Player)
            {
                Score.Coin = 0;
            }
            Score.DestroyGameUI();
        }
    }
}
