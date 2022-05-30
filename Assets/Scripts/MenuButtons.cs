using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject gameOverOverlay;
    public PlayerDeath playerDeath;
    public RespawnToLevelStart respawnToLevelStart;

    public void ReloadLastCheckpoint()
    {
        gameOverOverlay.SetActive(false);
        //playerDeath.playerDied = false;
        playerDeath.corpsePositionTracked = false;
        playerDeath.gameOver = false;
        playerDeath.collidedWithDeath = false;
        //respawnToLevelStart.playerRespawned = false;
        respawnToLevelStart.RespawnPlayer();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
