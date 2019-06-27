using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float leftForce = 2f;
    public float rightForce = 2f;
    public bool leftKey = false;
    public bool rightKey = false;
    public bool space = false;

    private Animator anim;
    private bool isDead = false;

    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();    
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
            //    Vector3 position = this.transform.position;
            //    position.x--;
            //    this.transform.position=position;
                space = true;

                // rb2d.velocity = Vector2.zero;
                // rb2d.AddForce(new Vector2(-leftForce, 0));
           }
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

            if (Input.GetKeyUp(KeyCode.Space))
            {
               space = false;
               
            }
            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
               leftKey = false;
               
            }
            
            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
               rightKey = false;
            }

            if (leftKey)
            {
                // rb2d.velocity = Vector2.zero;
                rb2d.AddForce(Vector2.left * 1, ForceMode2D.Impulse);
                anim.SetTrigger("left");
            }
            if (rightKey)
            {
                // rb2d.velocity = Vector2.zero;
                rb2d.AddForce(Vector2.right * 1, ForceMode2D.Impulse);
                anim.SetTrigger("right");
            }
            if (space)
            {
                GameControl.instance.Scrollspeed = -1f;
                Debug.Log("Speed: " + GameControl.instance.Scrollspeed);
                anim.SetTrigger("up");
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
