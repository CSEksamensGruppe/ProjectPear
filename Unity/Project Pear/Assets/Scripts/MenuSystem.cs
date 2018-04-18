﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSystem : MonoBehaviour {

    public void StartGameOnClick()
    {
        SceneManager.LoadScene("Level_01", LoadSceneMode.Single);
    }

    public void OptionsSceneOnClick()
    {
        SceneManager.LoadScene("OptionsScene", LoadSceneMode.Single);
    }

    public void QuitGameOnClick()
    {
        Application.Quit();
    }
    
}
