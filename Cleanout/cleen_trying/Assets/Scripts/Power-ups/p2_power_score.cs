using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class p2_power_score : MonoBehaviour
{
    public TextMeshProUGUI p2_powerScore ;
    public static int Score = 0;
    void Start()
    {
        p2_powerScore.text = "Powerup: " + Score.ToString();
    }

    void Update()
    {
        p2_powerScore.text = "Powerup: " + Score.ToString();
    }
}


