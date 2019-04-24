using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_first_player : MonoBehaviour
{
    
    public GameObject blue_clean;
    public GameObject yellow_clean;
    public float count_blue_right;
    /*public float count_blue_left;
    public float count_blue_up;
    public float count_blue_down;*/
    public float player1_speed = 2f; 
    private float sum = 0;
    public bool move = false;
    public float timer = .08f;
    public int counter = 0;
   




    private void Start()
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
                    Score_1.Score++;
                    counter++;
                    sum = counter;
                    Instantiate(blue_clean, transform.position, Quaternion.identity);
                    timeCounter = timer;
                }
            }
            
            
            yield return null;
            
        }

    }

    void Update()
    {
       
        float h = 0 ;
        float v = 0 ;

        if (Input.GetKey("d"))
        {
           
            h = 1 * Time.deltaTime * player1_speed;
            /*Score_1.Score++; 
           count_blue_right ++;*/
        }
       
        if (Input.GetKey("a"))
        {
            
            h = -1 * Time.deltaTime * player1_speed;
            //Score_1.Score++;
           // count_blue_left++; 
        }
        
        if (Input.GetKey("w"))
        {
            
            v = 1 * Time.deltaTime * player1_speed;
           // Score_1.Score++;
           // count_blue_up++;
        }
       
        if (Input.GetKey("s"))
        {
            
            v = -1 * Time.deltaTime * player1_speed;
           // Score_1.Score++;
           // count_blue_down++;
        }
        if (h != 0 || v != 0) move = true;
        else move = false;




        //sum = count_blue_right + count_blue_left + count_blue_down + count_blue_up;  // + count_green + count_red + count_white;
        
        transform.Translate (h,v,0 );
        print(sum);

    }





}
