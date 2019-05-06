using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollider : MonoBehaviour
{
    public float pushForce = 0.00001f;
    public Rigidbody2D rb;
    public float delay = 1f;
    float countDown;
    float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        countDown = delay;
    }

    private void Update()
    {
        speed = MouseMovement.Speed;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        string wall = other.gameObject.tag;

        switch (wall)
        {
            case "Right Wall":
                rb.velocity = speed * -transform.right;
                break;
            case "Left Wall":
                rb.velocity = speed * transform.right;
                break;
            case "Top Wall":
                rb.velocity = speed * -transform.up;
                break;
            case "Bottom Wall":
                rb.velocity = speed * transform.up;
                break;
            default: break;
        }
    }
}