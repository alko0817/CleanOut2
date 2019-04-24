using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollider : MonoBehaviour
{
    public float pushForce = 0.00001f;
    public Rigidbody2D rb;
    public float delay = 1f;
    float countDown;


    IEnumerator Hello ()
    {
        yield return new WaitForSeconds(0.15f);
        rb.velocity = Vector2.zero;
        rb.angularVelocity = 0;
        countDown = delay;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        countDown = delay;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine("Hello");
        if (other.gameObject.tag == "Right Wall")
        {
            rb.AddForce(Vector2.left * pushForce, ForceMode2D.Impulse);
        }
        if (other.gameObject.tag == "Left Wall")
        {
            rb.AddForce(-Vector2.left * pushForce, ForceMode2D.Impulse);
        }
        if (other.gameObject.tag == "Top Wall")
        {
            rb.AddForce(-Vector2.up * pushForce, ForceMode2D.Impulse);
        }
        if (other.gameObject.tag == "Bottom Wall")
        {
            rb.AddForce(Vector2.up * pushForce, ForceMode2D.Impulse);
        }
    }
}