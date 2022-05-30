using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject player;
    public GameObject playerCorpse;
    public GameObject gameOverOverlay;
    public bool gameOver = false;
    public bool playerDied = false;
    public bool corpsePositionTracked = false;
    public bool collidedWithDeath = false;
    public Vector3 playerPosition;

    // Update is called once per frame
    void Update()
    {
        DeathByDeathzone();
        DeathByCollision();
    }

    private void DeathByDeathzone() 
    {
        if(player.transform.position.y < -6.1 & !corpsePositionTracked)
        {
            playerPosition = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
            corpsePositionTracked = true;
        }

        if(player.transform.position.y < -6 & !gameOver)
        {
            player.SetActive(false);

            if(playerDied & !gameOver)
            {
                gameOver = true;
                ShowGameOver();
            }
            else
            {
                Instantiate(playerCorpse, playerPosition, Quaternion.identity);
                playerDied = true;
            }
        }
    }

    private void DeathByCollision()
    {
        if(collidedWithDeath & !playerDied)
        {
            playerPosition = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
            player.SetActive(false);
            Instantiate(playerCorpse, playerPosition, Quaternion.identity);
            playerDied = true;
            collidedWithDeath = false;
        }

        else if (collidedWithDeath & playerDied)
        {
            player.SetActive(false);
            gameOver = true;
            ShowGameOver();
        }
    }

    private void ShowGameOver()
    {
        gameOverOverlay.SetActive(true);
    }
}
