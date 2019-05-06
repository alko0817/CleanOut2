using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class immune : MonoBehaviour
{ 
    public static int protection = 10;
    public GameObject protectionEffect;
    public Collider2D p1;
    public Collider2D p2;
    public static bool def1 = false;
    public static bool def2 = false;

    void OnEnable()
    {
        p1 = GameObject.FindGameObjectWithTag("Player").GetComponent<BoxCollider2D>();
        //p2 = GameObject.FindGameObjectWithTag("Player 2").GetComponent<BoxCollider2D>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == p1 && !def2)
        {
            Instantiate(protectionEffect, transform.position, transform.rotation);
            StartCoroutine("Def1");           
        }
        if (collision == p2 && !def1)
        {
            Instantiate(protectionEffect, transform.position, transform.rotation);
            StartCoroutine("Def2");
        }
    }
    IEnumerator Def1 ()
    {
        def1 = true;
        yield return new WaitForSeconds(protection);
        def1 = false;
        Destroy(gameObject);
    }
    IEnumerator Def2()
    {
        def2 = true;
        yield return new WaitForSeconds(protection);
        def2 = false;

        Destroy(gameObject);
    }
}
