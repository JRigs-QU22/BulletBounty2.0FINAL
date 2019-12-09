using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject blast; //allows us to set object for blast
    public GameObject LGun; //loaded gun image
    public GameObject UGun; //unloaded gun image
    private Vector2 myLocation; //makes Vector 2 for blast position
                                // Start is called before the first frame update

    public Quaternion blastRot; // Saves the transform.rotation to a variable

    int Ammo = 1; //sets player to have one shot

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        var objectPos = Camera.main.WorldToScreenPoint(transform.position); //sets camera position for gun

        var dir = Input.mousePosition - objectPos; //controls the direction of the shot


        blastRot = Quaternion.Euler(new Vector3(0, 0, Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg)); //Calculates the rotation of shot based on mouse position

        if (Input.GetKeyDown(KeyCode.Mouse0))// on left click
        { 
            myLocation = gameObject.transform.position; //sets blast location at player position

            Instantiate(blast, new Vector2(myLocation.x, myLocation.y), blastRot); //makes new blast in blastRot direction

            Ammo --; //subtract one ammo
            if (Ammo < 1) { //after shot, disable gun script
                LGun.SetActive(false);
                UGun.SetActive(true);
                gameObject.GetComponent<Gun>().enabled = false; //disable gun script
            }
        }
    }
}//Based on code provided by Liam Day and rotation provided by Matt D on Discord

