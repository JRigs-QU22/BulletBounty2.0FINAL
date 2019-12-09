using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Xspeed; //sets a variable for vertical speed
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Xspeed, 0, 0); //transforms the blast position on the y-axis

     //   if (transform.position.y > 20f) //if blast goes above 20f, destroy it
       // {
         //   Destroy(gameObject);
       // }
        //if (transform.position.y > -10f) //if blast goes below -10f, destroy it
       // {
          //  Destroy(gameObject);
        //}
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy") //if bullet is hit by object with enemy tag
        {
            Destroy(gameObject); //destroy object immeadiately
        }
        if (collision.gameObject.tag == "Prop") //if bullet is hit by object with prop tag
        {
            Destroy(gameObject); //destroy object immeadiately
        }
    }

}//made by me but assisted by Liam Day
