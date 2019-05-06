using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToKillP2 : MonoBehaviour
{
    public GameObject Enemy;
    float clicked = 0;
    public float clicks = 10;
    public Collider2D player;

    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown("space"))
        {
            clicked++;
        }
        if (clicked > clicks)
        {   
            Enemy.SetActive(false);
            StartCoroutine("Yeet");
            clicked = 0;
        }
    }

    IEnumerator Yeet()
    {
        yield return new WaitForSeconds(5);
        Enemy.SetActive(true);
    }
}