using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBG : MonoBehaviour
{
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Debug.Log(GameControl.instance.BGScrollspeed);
        rb2d.velocity = new Vector2 (0,-GameControl.instance.BGScrollspeed);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameControl.instance.gameOver == true)
        {
            rb2d.velocity = Vector2.zero;
        }
    }
}