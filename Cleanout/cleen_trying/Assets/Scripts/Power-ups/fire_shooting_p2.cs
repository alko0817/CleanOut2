using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_shooting_p2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 4);
    }


   public void OnTriggerEnter2D( Collider2D other)
    {  if (other.gameObject.tag == "Blue_one")
        {
            Destroy(other.gameObject , 1);

            Destroy( gameObject  , 1);
            Score_1.Score-=6;
        }
        
    }
}
