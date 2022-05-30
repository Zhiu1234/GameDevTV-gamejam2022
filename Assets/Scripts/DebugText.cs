using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class DebugText : MonoBehaviour
{
    public TMP_Text debugText;
    public GameObject player;
    //public IPlayerController playerController;

    //void Awake() => playerController = player.GetComponent<IPlayerController>();

    // Update is called once per frame
    void Update()
    {
        //debugText.text = "localScale = "+player.transform.localScale.x.ToString();
        //debugText.text = "Input.X = "+playerController.Input.X.ToString();
    }
}
