using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject Player;
    public GameObject DeadScreen;
    public ScoreSystem Score;

    private bool deadScreenSpawned = false;

    void LateUpdate()
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

    public void LoadNextLevel()
    {
        int nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextLevel);
    }

}
