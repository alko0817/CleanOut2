using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 1;
    public float speedMod = 3;
    public Vector2 direction;
    public float waitFor;
    public float andStopIn;
    public GameObject[] directions;
    GameObject lastSprite;
    public Vector2 pointing;
    public float andStartin;
    public float otherSide;
    public float Lastly;
    public float stopIt;
    public SpriteRenderer sprite;
    int i;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lastSprite = directions[0];
        StartCoroutine("oneSec");
        StartCoroutine("clock");
        StartCoroutine("counter");
        StartCoroutine("speedUp");
    }

    IEnumerator oneSec ()
    {        
        yield return new WaitForSeconds(waitFor);
        rb.velocity = speed * direction;
        yield return new WaitForSeconds(andStopIn);
        rb.velocity = new Vector2(0, 0);       
    }

    IEnumerator clock()
    {
        yield return new WaitForSeconds(andStartin);
        rb.velocity = speed * direction;
        yield return new WaitForSeconds(1);
        i = 1;
        rb.velocity = speed * -transform.up;
        changeSp(i);
        sprite.enabled = false;

        yield return new WaitForSeconds(1);
        i = 2;
        changeSp(i);
        rb.velocity = speed * new Vector2(-1, -1);

        yield return new WaitForSeconds(1);
        i = 3;
        changeSp(i);
        rb.velocity = speed * -transform.right;

        yield return new WaitForSeconds(1);
        i = 4;
        changeSp(i);
        rb.velocity = speed * new Vector2(-1, 1);

        yield return new WaitForSeconds(1);
        i = 5;
        changeSp(i);
        rb.velocity = speed * transform.up;

        yield return new WaitForSeconds(1);
        i = 6;
        changeSp(i);
        rb.velocity = speed * new Vector2(1, 1);

        yield return new WaitForSeconds(1);
        i = 7;
        changeSp(i);
        rb.velocity = speed * transform.right;

        yield return new WaitForSeconds(1);
        directions[i].SetActive(false);
        lastSprite = directions[0];
        sprite.enabled = true;
        rb.velocity = pointing;
    }

    IEnumerator counter()
    {
        yield return new WaitForSeconds(otherSide);
        rb.velocity = speed * direction;
        yield return new WaitForSeconds(1);
        i = 7;
        rb.velocity = speed * transform.right;
        changeSp(i);
        sprite.enabled = false;

        yield return new WaitForSeconds(1);
        i = 6;
        changeSp(i);
        rb.velocity = speed * new Vector2(1, 1);

        yield return new WaitForSeconds(1);
        i = 5;
        changeSp(i);
        rb.velocity = speed * transform.up;

        yield return new WaitForSeconds(1);
        i = 4;
        changeSp(i);
        rb.velocity = speed * new Vector2(-1, 1);

        yield return new WaitForSeconds(1);
        i = 3;
        changeSp(i);
        rb.velocity = speed * -transform.right;

        yield return new WaitForSeconds(1);
        i = 2;
        changeSp(i);
        rb.velocity = speed * new Vector2(-1, -1);

        yield return new WaitForSeconds(1);
        i = 1;
        changeSp(i);
        rb.velocity = speed * -transform.up;

        yield return new WaitForSeconds(1);
        directions[i].SetActive(false);
        lastSprite = directions[0];
        sprite.enabled = true;
        rb.velocity = pointing;

    }

    IEnumerator speedUp ()
    {
        yield return new WaitForSeconds(Lastly);
        rb.velocity = speed * speedMod * direction;
        yield return new WaitForSeconds(stopIt);
    }

    void changeSp (int i)
    {
        lastSprite.SetActive(false);
        directions[i].SetActive(true);
        lastSprite = directions[i];
    }
}
