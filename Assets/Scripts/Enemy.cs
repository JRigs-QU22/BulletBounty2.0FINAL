using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    //public Text TellPlay; //provides slot for text
    public GameObject Enemies; //provides slot to insert enemies
   // public int score; //sets int for score;
   // public Text TellPlay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Bullet") //if enemy is hit by bullet...
        {
          //  score ++; //increase score by one
         //   TellPlay.text = "Money Earned: $" + score; //update text field with score
            Destroy(Enemies); //destroy object immeadiately
            Debug.Log("Kill"); //send kill message to console
        }
    }
}