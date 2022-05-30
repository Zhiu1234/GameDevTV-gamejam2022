using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnToLevelStart : MonoBehaviour
{
    public GameObject player;
    public Transform respawnArea;
    public PlayerDeath playerDeath;
    public bool playerRespawned = false;

    // Update is called once per frame
    void Update()
    {
        if(playerDeath.playerDied & !playerRespawned)
        {
            RespawnPlayer();
        }
    }

    public void RespawnPlayer()
    {
        player.transform.position = respawnArea.position;
        player.SetActive(true);
        playerRespawned = true;
    }
}
