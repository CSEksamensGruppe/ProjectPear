using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Player") || col.collider.CompareTag("Enemy"))
        {
            Destroy(col.gameObject);
        }
    }


}
