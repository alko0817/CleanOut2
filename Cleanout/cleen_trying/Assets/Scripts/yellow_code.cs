using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellow_code : MonoBehaviour
{
    public GameObject yellow_spawn; 
    public void OnTriggerEnter2D(Collider2D other)
    {      
        if (other.gameObject.tag== "Blue_one")
        {
            Instantiate(yellow_spawn, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
           Score2_.Score_2--; 
        }
    }
}
