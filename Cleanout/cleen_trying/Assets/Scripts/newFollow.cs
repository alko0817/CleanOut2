using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newFollow : MonoBehaviour
{
    public Transform p1;
    public Transform p2;

   public static bool p1Follow = false;
   public static bool p2Follow = false;
    public newAI3 ai;
    public float distance = 10f;
    public Vector2 back;
    

    void Start()
    {
        p1 = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        //p2 = GameObject.FindGameObjectWithTag("Player 2").GetComponent<Transform>();
    }
    void Update()
    {
     
        if (p1Follow)
        {
            transform.position = Vector2.MoveTowards(transform.position, p1.transform.position * back, distance * Time.deltaTime);
            
            Score_1.Score += 1; 
        }
        if (p2Follow)
        {
            transform.position = Vector2.MoveTowards(transform.position, p2.transform.position, distance * Time.deltaTime);
            
            Score2_.Score_2 += 1;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string player = collision.gameObject.tag;
        if (player == "Player")
        {
            
            ai.enabled = false;
            p1Follow = true;
        }
        if (player == "Player 2")
        {
            
            ai.enabled = false;
            p2Follow = true;
        }
    }
}
