using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KneeCap : MonoBehaviour
{
    public GameObject gun; //creates slot for gun object
    public GameObject kneeText; //creates slot for text to display

    // Start is called before the first frame update
    void Start()
    {
        kneeText.SetActive(false); //set text to inactive
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Bullet") //if enemy hit by bullet on knee
        {
            Debug.Log("knee"); //print knee to console
            kneeText.SetActive(true); //set the text to active
            Destroy(kneeText, 2f); //destroy thr text after 2 seconds
            //gun.GetComponent<EnemyShoot>().enabled = false;
            Destroy(gun); //destroy gun object (prevents shooting)
            
        }
    }
}
