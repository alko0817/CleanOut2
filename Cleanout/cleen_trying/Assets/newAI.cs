using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newAI : MonoBehaviour
{

    public int moveSpeed = 140;  //per second 
    Vector3 computerDirection = Vector3.left;
    Vector3 moveDirection = Vector3.zero;
    Vector3 newPosition = Vector3.zero;
    public Transform player_1;
    public Transform player_2;
    public bool follow_player = false;
    public SpriteRenderer m_spriteRenderer;
    Color new_colour;
    public bool yellow_true = false;
    public bool blue_true = false;


    void Start()
    {
        player_1 = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        player_2 = GameObject.FindGameObjectWithTag("Player 2").GetComponent<Transform>();
        m_spriteRenderer = GetComponent<SpriteRenderer>();

    }

    void Update()
    {
        Vector3 newPosition = computerDirection * (moveSpeed * Time.deltaTime);
        newPosition = transform.position + newPosition;
        newPosition.x = Mathf.Clamp(newPosition.x, -101, 126);
        transform.position = newPosition;
        if (newPosition.x > 126)
        {
            newPosition.x = 126;
            computerDirection.x *= -1;
        }
        else if (newPosition.x < -101)
        {
            newPosition.x = -101;
            computerDirection.x *= -1;
        }


        if (yellow_true)
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
