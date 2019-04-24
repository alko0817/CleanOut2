using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_first_player : MonoBehaviour
{
    public GameObject white_clean;
    public GameObject green_clean;
    public GameObject red_clean;
    public GameObject blue_clean;
    public float count_blue_right;
    public float count_blue_left;
    public float count_blue_up;
    public float count_blue_down;
    /* public float count_green;
     public float count_red;
     public float count_blue;*/
    public float player1_speed = 2f; 
    private float sum = 0; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float h = 0 ;
        float v = 0 ; 

    //float v = Input.GetAxis("Vertical") * Time.deltaTime;

        if (Input.GetKey("d"))
        {
            Instantiate(blue_clean, transform.position, Quaternion.identity);
            h = 1 * Time.deltaTime * player1_speed;
            Score_1.Score++; 
           count_blue_right ++;
        }
        if (Input.GetKey("a"))
        {
            Instantiate(blue_clean, transform.position, Quaternion.identity);
            h = -1 * Time.deltaTime * player1_speed;
            Score_1.Score++;
            count_blue_left++; 
        }
        if (Input.GetKey("w"))
        {
            Instantiate(blue_clean, transform.position, Quaternion.identity);

            v = 1 * Time.deltaTime * player1_speed;
            Score_1.Score++;
            count_blue_up++;
        }
        if (Input.GetKey("s"))
        {
            Instantiate(blue_clean, transform.position, Quaternion.identity);

            v = - 1 * Time.deltaTime * player1_speed;
            Score_1.Score++;
            count_blue_down++; 
        }

        sum = count_blue_right + count_blue_left + count_blue_down + count_blue_up;  // + count_green + count_red + count_white;
       
        transform.Translate (h,v,0 );
        print(sum);

    }


}
