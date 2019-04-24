using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Time_and_score : MonoBehaviour
{
    public float waitTime;
    public float times;

    void Start()
    {
        //Cursor.visible = false;
    }

    void Update()
    {
        if (times > 0.0f)
        {
            times -= Time.deltaTime;
        }

        if (times < 2)
        {
            check_score();
        }
    }

    void check_score()
    {
        if (Score2_.Score_2 > Score_1.Score)
        {
            SceneManager.LoadScene(3);
            print("Player2 is the winner");
        }

        else if (Score2_.Score_2 < Score_1.Score)
        {
            SceneManager.LoadScene(2);
        }
        else if (Score2_.Score_2 == Score_1.Score)
        {
            SceneManager.LoadScene(4);
        }
    }
}