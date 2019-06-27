using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other);
        if(other.GetComponent<player>() != null)
        {
            //If the bird hits the trigger collider in between the columns then
            //tell the game control that the bird scored.
            GameControl.instance.Score();
        }
    }
}
