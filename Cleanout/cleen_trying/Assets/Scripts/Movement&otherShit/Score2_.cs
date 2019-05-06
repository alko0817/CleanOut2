using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score2_ : MonoBehaviour
{
    public TextMeshProUGUI t_score;
    public static int Score_2 = 0;

    void Start()
    {
        t_score.text = Score_2.ToString();
    }

    void Update()
    {
        t_score.text = Score_2.ToString();
    }
}

