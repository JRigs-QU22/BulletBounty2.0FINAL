using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public GameObject player; //provides slot to insert player
    private Vector3 offset; //creates offset variable for camera position relative to player
    // Start is called before the first frame update
    void Start()
    {
        offset = (transform.position - player.transform.position) * 5; //sets offset of camera
    }

    // Update is called once per frame
    void Update()
    {

            // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
            transform.position = player.transform.position + 0.2f * offset;

        
    }
}

