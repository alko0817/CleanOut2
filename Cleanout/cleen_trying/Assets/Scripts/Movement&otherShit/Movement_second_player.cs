using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Movement_second_player : MonoBehaviour
{
    public GameObject Player_2;
    public Text text_player1; 
    public GameObject yellow_clean;
    public GameObject Fire_shoot ;
    int counter = 0;
    public float player_2_speed = 2f;
    float sum = 0;
    bool move = false;
    public float timer = .5f;

    void OnEnable()
    {
        StartCoroutine("MopInfluence");       
    }

    IEnumerator MopInfluence()
    {
        float timeCounter = 0f;
        while (true)
        {
            if (move == true)
            {
                if (timeCounter > 0)
                {
                    timeCounter -= Time.deltaTime;
                }
                else
                {
                    Score2_.Score_2++;
                    counter++;
                    sum = counter;
                    Instantiate(yellow_clean, transform.position, Quaternion.identity);
                    timeCounter = timer;
                }
            }
            yield return null;
        }
    }

    void Update()
    {
        #region Movement
            float h = 0;
            float v = 0;

            if (Input.GetKey("right"))
            {
                h = 1 * Time.deltaTime * player_2_speed;
            }
            if (Input.GetKey("left"))
            {
                h = -1 * Time.deltaTime * player_2_speed;
            }
            if (Input.GetKey("up"))
            {
                v = 1 * Time.deltaTime * player_2_speed;
            }
            if (Input.GetKey("down"))
            {
                v = -1 * Time.deltaTime * player_2_speed;
            }
            if (h != 0 || v != 0) move = true;
            else move = false;
            transform.Translate(h, v, 0);
        #endregion

        if (p2_power_score.Score > 0)
        {
            if (Input.GetButtonDown("p2_shoot"))
            {
                Instantiate(Fire_shoot, transform.position, transform.rotation);              
                p2_power_score.Score--;
                if (p2_power_score.Score < 1)
                {
                    p2_power_score.Score = 0;
                }
            }
        }
        
    }
 
    public void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Fire_")
        {
            Destroy(other.gameObject);
            p2_power_score.Score++;
        }
    }

}
