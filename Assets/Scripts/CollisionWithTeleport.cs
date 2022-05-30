using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithTeleport : MonoBehaviour
{
    public GameObject gameWonOverlay;
    public bool teleporterReached = false;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Teleport"))
        {
            gameWonOverlay.SetActive(true);
            teleporterReached = true;
        }
    }
}
