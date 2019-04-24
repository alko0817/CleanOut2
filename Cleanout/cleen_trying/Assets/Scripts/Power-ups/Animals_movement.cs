using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals_movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool go_around = true;

    public bool yellow_true = false;
    public bool blue_true = false ;
    public Transform player_1;
    public Transform player_2;

    public bool follow_player = false ;
    public SpriteRenderer m_spriteRenderer;
    Color new_colour; 
    // Start is called before the first frame update
    void Start()
    {
        player_1 = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        player_2 = GameObject.FindGameObjectWithTag("Player 2").GetComponent<Transform>(); 
        m_spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (go_around)
        {
            rb.AddForce(new Vector3(Random.Range(-20, 20) * 3 * Time.deltaTime, Random.Range(-20, 20) * 4 * Time.deltaTime, 0));
        }

        if (yellow_true )
        {
            blue_true = false;
            transform.position = Vector2.MoveTowards(transform.position, player_1.transform.position, 5 * Time.deltaTime);
           
        }


       else if (blue_true)
        {
            yellow_true = false;
            transform.position = Vector2.MoveTowards(transform.position, player_2.transform.position, 5 * Time.deltaTime);
          
        }

    }

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player 2")
        {
            m_spriteRenderer.color = Color.blue;
            blue_true = true; 
          //  new_colour = Color.blue; 
            // let color be green 
            // if color is yellow are equal to true ... let it follow player 1  ; 
            // if color is  black are true ... let it follow player 2  ; 
        }


        if (other.gameObject.tag == "Player")
        {
            m_spriteRenderer.color = Color.yellow;
            yellow_true = true; 
            //  new_colour = Color.blue; 
            // let color be green 
            // if color is yellow are equal to true ... let it follow player 1  ; 
            // if color is  black are true ... let it follow player 2  ; 
        }
    }
}
