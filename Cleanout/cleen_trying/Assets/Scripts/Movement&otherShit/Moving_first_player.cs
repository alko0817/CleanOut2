using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_first_player : MonoBehaviour
{  
    public GameObject Fire_shoot; 

    void Update()
    {      
        if (p1_power_score.Score > 0)
        {
            if (Input.GetButtonDown("p1_shoot"))
            {
                Instantiate(Fire_shoot, transform.position, transform.rotation);
                p1_power_score.Score--;

                if (p1_power_score.Score < 1)
                {
                    p1_power_score.Score = 0;
                }
            }
        }    
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Fire_")
        {
            Destroy(other.gameObject);
            p1_power_score.Score++;
        }
    }
}
