using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    // Player object
    private GameObject _player;

    // Runs at the start of the scene
    void Start()
    {
        _player = GameObject.Find("Player");
    }

    // When another object enters the collider.
    void OnCollisionEnter2D(Collision2D col)
    {
        // If the colliding object has the tag "Player" destroy the player.
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(_player);
        }
    }

}
