using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithTrap : MonoBehaviour
{
    public PlayerDeath playerDeath;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Trap"))
        {
            playerDeath.collidedWithDeath = true;
        }
    }
}
