using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private ScoreSystem sm;

	// Use this for initialization
	void Start ()
	{
	    sm = FindObjectOfType<ScoreSystem>();
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            sm.Coin++;
            Destroy(gameObject);
        }
    }

}
