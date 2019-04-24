using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_yellow : MonoBehaviour
{
    public GameObject blue_one; 
    public float count_yellow = 0 ; 

    public void OnTriggerEnter2D(Collider2D other)
    {
         if (other.gameObject.tag == "Yellow_one")
        {
            Instantiate(blue_one, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Score_1.Score--; 
            count_yellow++;
            print(count_yellow); 
        }    
    }
}
