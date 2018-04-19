﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject Player;
    public GameObject DeadScreen;

    private bool deadScreenSpawned = false;

    void LateUpdate()
    {
        if (!Player && !deadScreenSpawned)
        {
            Instantiate(DeadScreen, new Vector3(0, 0, 0), Quaternion.identity);
            deadScreenSpawned = true;
        }
    }

}
