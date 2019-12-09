using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject blast; //allows us to set object for blast
    private Vector2 myLocation; //makes Vector 2 for blast position
    public float secsBetweenLaunch = 1f; //sets time nterval between shots
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 2f, secsBetweenLaunch);  //calls a function every x secs 2f from start of game
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Fire()
    {
        var Shot = Random.Range(1, 4); //sets range for enemy shooting
        if (Shot == 2 || Shot == 4) //if space button is pressed
        {
            myLocation = gameObject.transform.position; //sets blast location at player position

            Instantiate(blast, new Vector2(myLocation.x, myLocation.y), transform.rotation); //makes new blast in upwards direction
        }

    }
}//Based on code provided by Liam Day

