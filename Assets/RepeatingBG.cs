using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour
{
 
    private float skyverticallength;

    // Start is called before the first frame update
    void Start()
    {

        skyverticallength = 25.6f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > skyverticallength)
        {
            RepositionBackground();
        }
    }

    private void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2 (0,skyverticallength * -2f);
        transform.position = (Vector2) transform.position + groundOffset;
    }
}
