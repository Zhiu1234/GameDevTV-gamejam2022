using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWIthCheckpoint : MonoBehaviour
{
    public PlayerDeath playerDeath;
    public RespawnToLevelStart respawnToLevelStart;
    public GameObject respawnArea;
    public Vector3 checkpointPosition;
    public Animator checkpointAnimator;
    public string checkpoint = "Checkpoint";

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Checkpoint"))
        {
            playerDeath.playerDied = false;
            playerDeath.corpsePositionTracked = false;
            respawnToLevelStart.playerRespawned = false;
            checkpointPosition = other.transform.position;
            respawnArea.transform.position = checkpointPosition;
            other.gameObject.SetActive(false);
            checkpointAnimator.Play(checkpoint, 0, 0.0f);
        }
    }
}
