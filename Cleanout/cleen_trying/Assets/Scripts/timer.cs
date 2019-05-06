using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.UI;


public class timer : MonoBehaviour
{


    public TextMeshProUGUI timerDown; 
    
    float countDown;
    int flatDown;

   
    void Start()
    {
        timerDown.text = "Time : " + flatDown.ToString();
    }

    void Update()
    {
        countDown = GameObject.Find("Main Camera").GetComponent<Time_and_score>().timer;
        flatDown = Mathf.RoundToInt(countDown);

        timerDown.text = "Time : " + flatDown.ToString();

    }
}
