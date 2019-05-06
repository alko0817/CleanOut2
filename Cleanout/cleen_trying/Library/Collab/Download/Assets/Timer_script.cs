using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
 
using UnityEngine.UI;
 

public class Timer_script : MonoBehaviour
{
    
 
    public Text  Time_Score;
    public  static float Score_t = 120f;

    void Start()
    {
            Time_Score.text = "Time : " + Score_t.ToString();
    }

    void Update()
    {
            Time_Score.text = "Time :" + Score_t.ToString();

    }
}