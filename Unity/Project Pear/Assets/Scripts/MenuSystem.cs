using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSystem : MonoBehaviour {

    void StartGameOnClick()
    {
        SceneManager.LoadScene("Level_01");
    }


}
