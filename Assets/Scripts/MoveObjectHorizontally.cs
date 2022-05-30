using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectHorizontally : MonoBehaviour
{
    public int speed;
    public bool facingRight = true;

    // Update is called once per frame
    void Update()
    {
        if (facingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else 
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(facingRight)
        {
            facingRight = false;
        }
        else
        {
            facingRight = true;
        }      
    }
}
