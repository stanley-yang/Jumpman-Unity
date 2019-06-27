using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float leftForce = 1f;
    public float rightForce = 1f;
    public bool leftKey = false;
    public bool rightKey = false;


    private bool isDead = false;

    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
           if (Input.GetKeyDown(KeyCode.LeftArrow))
           {
            //    Vector3 position = this.transform.position;
            //    position.x--;
            //    this.transform.position=position;
                leftKey = true;

                // rb2d.velocity = Vector2.zero;
                // rb2d.AddForce(new Vector2(-leftForce, 0));
           }
           if (Input.GetKeyDown(KeyCode.RightArrow))
           {
            //    rb2d.velocity = Vector2.zero;
            //     rb2d.AddForce(new Vector2(rightForce, 0));

                rightKey = true;


            //    Vector3 position = this.transform.position;
            //    position.x++;
            //    this.transform.position=position;
           }

            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
               leftKey = false;
            }
            
            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
               rightKey = false;
            }

            if (leftKey)
            {
                // rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(-leftForce, 0));
            }
            if (rightKey)
            {
                // rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(rightForce, 0));
            }


        }
    }
    //blah
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("hit");
        rb2d.velocity = Vector2.zero;
        isDead = true;
        GameControl.instance.playerDied();
    }
}
