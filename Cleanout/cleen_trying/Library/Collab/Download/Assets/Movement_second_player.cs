using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Movement_second_player : MonoBehaviour
{
    public Text text_player1; 
    public GameObject yellow_clean;
    public float count_yellow_right;
    public float count_yellow_left;
    public float count_yellow_up;
    public float count_yellow_down;

    public float player_2_speed = 2f;
    public float sum = 0; 

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

      /*  float h = Input.GetAxis("Horizontal") * Time.deltaTime * 2f;
        float v = Input.GetAxis("Vertical") * Time.deltaTime * 2f ;
        transform.Translate(h, v, 0);

    */

         


        float h = 0;
        float v = 0;

        //float v = Input.GetAxis("Vertical") * Time.deltaTime;

        if (Input.GetKey("l"))
        {
            Instantiate(yellow_clean, transform.position, Quaternion.identity);
            h = 1 * Time.deltaTime * player_2_speed;
            Score2_.Score_2++; 
            count_yellow_left++; 
        }
        if (Input.GetKey("k"))
        {
            Instantiate(yellow_clean, transform.position, Quaternion.identity);
            h = -1 * Time.deltaTime * player_2_speed;
            Score2_.Score_2++; 

            count_yellow_right++;
        }
        if (Input.GetKey("o"))
        {
            Instantiate(yellow_clean, transform.position, Quaternion.identity);

            v = 1 * Time.deltaTime * player_2_speed;
            Score2_.Score_2++;

            count_yellow_up++;
        }
        if (Input.GetKey("m"))
        {
            Instantiate(yellow_clean, transform.position, Quaternion.identity);

            v = -1 * Time.deltaTime * player_2_speed;
            Score2_.Score_2++;

            count_yellow_down++;
        }

        sum  = count_yellow_left + count_yellow_right + 
            count_yellow_up + count_yellow_down;  // + count_green + count_red + count_white;
        print(sum);
        transform.Translate(h, v, 0);

 
    }
}
