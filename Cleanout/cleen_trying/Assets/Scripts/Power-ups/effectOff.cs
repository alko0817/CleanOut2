using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effectOff : MonoBehaviour
{

    void Start()
    {
        Destroy(gameObject, immune.protection );
    }
}



