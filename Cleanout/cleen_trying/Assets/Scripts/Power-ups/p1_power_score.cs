using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class p1_power_score : MonoBehaviour
{ 
    public TextMeshProUGUI p1_powerScore;
    public static int Score = 0;
   
    void Start()
    {
        p1_powerScore.text = "Powerup: " + Score.ToString();
    }

    void Update()
    {
        p1_powerScore.text = "Powerup: " + Score.ToString();

    }
}
