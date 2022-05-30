using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TarodevController {
    public class CameraController : MonoBehaviour {
        private IPlayerController playerController;

        public GameObject player;
        public float offset;
        public float offsetSmoothing;
        public float cameraLockPosition;
        private Vector3 playerPosition;
        private bool playerFacingRight = true;

        void Awake() => playerController = player.GetComponent<IPlayerController>();

        // Update is called once per frame
        void Update()
        {
            if(player.transform.position.y > cameraLockPosition)
            {
                playerPosition = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
            }
            else
            {
                playerPosition = new Vector3(player.transform.position.x, cameraLockPosition, transform.position.z);
            }

            //if(player.transform.localScale.x > 0f)
            if(playerController.Input.X == 1f)
            {
                playerFacingRight = true;
            }
            
            if (playerController.Input.X == -1f)
            {
                playerFacingRight = false;
            }
                      
            
            if(playerFacingRight)
            {
                playerPosition = new Vector3(playerPosition.x + offset, playerPosition.y, playerPosition.z);
            }
            else
            {
                playerPosition = new Vector3(playerPosition.x - offset, playerPosition.y, playerPosition.z);
            }

            transform.position = Vector3.Lerp(transform.position, playerPosition, offsetSmoothing * Time.deltaTime);
        }
    }
}