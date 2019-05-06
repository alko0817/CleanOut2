using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newAI3 : MonoBehaviour
{

    Vector2 move;
    public int i;
    private Rigidbody2D rb;
    public float movSpeed = 1f;
    public float timer = 2f;




    void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine("AI");
    }
    IEnumerator AI()
    {
        float timeCounter = 0f;
        while (true)
        {
            if (timeCounter > 0) timeCounter -= Time.deltaTime;
            else
            {
                i = Random.Range(0, 7);
                timeCounter = timer;
            }
            yield return null;
            
        }
    }
   
    void Update()
    {
        rb.velocity = movSpeed * move;

        #region AIMovement

        switch (i)
        {
            case 0:
                move =- transform.up ;
                break;
            case 1:
                move =  transform.up ;
                break;
            case 2:
                move = transform.right   ;
                break;
            case 3:
                move = -transform.right    ;
                break;
            case 4:
                move = new Vector2(1, 1);
                break;
            case 5:
                move = new Vector2(-1, 1);
                break;
            case 6:
                move = new Vector2(1, -1);
                break;
            case 7:
                move = new Vector2(-1, -1);
                break;
            default:
                move = new Vector2(1, -1);
                break;
        }
        #endregion
        
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        string wall = collision.gameObject.tag;

        switch (wall)
        {
            case "Left Wall":
                i = 2;
                break;
            case "Right Wall":
                i = 3;
                break;
            case "Bottom Wall":
                i = 1;
                break;
            case "Top Wall":
                i = 0;
                break;
            default:
                i = Random.Range(0, 7);
                break;
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        string wall = collision.gameObject.tag;

        switch (wall)
        {
            case "Left Wall":
                i = 2;
                break;
            case "Right Wall":
                i = 3;
                break;
            case "Bottom Wall":
                i = 1;
                break;
            case "Top Wall":
                i = 0;
                break;
            default:
                i = Random.Range(0, 7);
                break;
        }

    }
}
