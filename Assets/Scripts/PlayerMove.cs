using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public Text tellplay; // text field to update
    int hits; // counts how many times player gets hit

    public Slider healthBar;


    public Animator anim;
    float horizontalMove = 0f;

    float runSpeed = 4.0f;
    bool jump = false;
    public float jumpForce = 5000;
    public bool canControl = true;

    public Vector2 startPos;
    public Vector2 peakPos;

    public int maxHealth = 50;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.minValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = currentHealth;
        if (canControl == true)
        {

            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

            anim.SetFloat("Speed", Mathf.Abs(horizontalMove));

            if (Input.GetKey(KeyCode.D)) //if d key is pressed, move in right direction
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(4, 0);
            }
            else if (Input.GetKey(KeyCode.A)) //if a key is pressed, move in left direction
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-4, 0);
            }
            else if (Input.GetKeyDown(KeyCode.W)) //if spacebar is pressed, move in up direction
            {
                anim.SetTrigger("jump");
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce * 80));
                GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 10, 0), ForceMode2D.Impulse);

                Debug.Log("jump");
            }

            else if (Input.GetKey(KeyCode.S)) //if down arrow key is pressed, move in down direction
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -4);
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0); //if neither is pressed, don't move at all
            }
        }

    }



    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "EBullet") //if alien is hit by object with bottom tag
        {
            takeDamage(10); //increase hit int by one
            //tellplay.text = "Hits Taken:" + hits; //Print this to console 

            if (healthBar.GetComponent<Slider>().value == 0) //if you get hit 5 times
            {
                Destroy(gameObject); //destroy plsyer

                SceneManager.LoadScene("Scene_Lose"); //Load lose screen
            }

        }
        if (collision.gameObject.tag == "Fall")
        {
            Destroy(gameObject);

            SceneManager.LoadScene("Scene_Lose"); //Load lose screen
        }

        if(collision.gameObject.tag == "Grounded")
        {
            anim.SetTrigger("grounded");
        }

        if (collision.gameObject.tag == "Prop")
        {
            anim.SetTrigger("grounded");
        }
    }

    public IEnumerator jumpAnimation()
    {
        yield return null;


        startPos = new Vector2(transform.position.x, transform.position.y);
        peakPos = new Vector2(startPos.x + 1.2031f, startPos.y + .7847f);


        canControl = false;
        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;
        GetComponent<Rigidbody2D>().isKinematic = true;

        transform.position = Vector2.Lerp(startPos, peakPos, 1 * Time.deltaTime);


    }

    public void takeDamage(int amount)
    {
        if(currentHealth > 0)
        {
            currentHealth -= amount;
            Debug.Log("I'm Hit!");
        }
        
    }

}
