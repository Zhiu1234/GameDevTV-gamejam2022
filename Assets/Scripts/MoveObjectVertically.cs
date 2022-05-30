using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectVertically : MonoBehaviour
{
    public int speed;
    public bool facingUp = true;

    // Update is called once per frame
    void Update()
    {
        if (facingUp)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else 
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(facingUp)
        {
            facingUp = false;
        }
        else
        {
            facingUp = true;
        }      
    }
}
