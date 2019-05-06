using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score_1 : MonoBehaviour
{
    public TextMeshProUGUI t_score;
    public static int Score = 0;
    void Start()
    {
        t_score.text = Score.ToString();
    }

    void Update()
    {
       
        t_score.text = Score.ToString();
    }
}
 
