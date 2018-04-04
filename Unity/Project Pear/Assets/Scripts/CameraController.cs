using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Da vores spiller skal være i fokus, er det vigtigt at vi kan vælge hvilket objekt der er vores spiller.
    public GameObject Player;

    // We need the cameras position, and an offset, so that we don't move the camera inside our player, but instead uses an offset.
    // See more @ https://docs.unity3d.com/ScriptReference/Vector3.html
    private Vector3 _offset;

    // When the scene is played this method will be called.
    void Start()
    {
        // Creating the offset by taking the distance between the camera and the player object.
        _offset = transform.position - Player.transform.position;
    }

    // Runs every frame, if the camera is active.
    void LateUpdate()
    {
        // Adds the offset to the camera, so that it follows but keeps its distance.
        transform.position = Player.transform.position + _offset;
    }
}
