using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToKill : MonoBehaviour
{
    public GameObject Enemy;
    float clicked = 0;
    public float clicks = 10;
   // public Collider2D player;

    void OnTriggerStay2D(Collider2D other)
    {         
      if (Input.GetMouseButtonDown(0))
        {
            clicked++;
        }
        if (clicked > clicks)
        {
            Enemy.SetActive(false);
            StartCoroutine("BobRoss");
            clicked = 0;
        }  
    }

    IEnumerator BobRoss()
    {
        yield return new WaitForSeconds(5);
        Enemy.SetActive(true);
    }
}
