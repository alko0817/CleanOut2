using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1_shooting : MonoBehaviour
{
    void Update()
    {       
        Destroy(gameObject, 10);         
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Yellow_one")
        {
            Destroy(other.gameObject, 1);
            Destroy(gameObject, 1);
            Score2_.Score_2 -=6; 
        }
    }
}