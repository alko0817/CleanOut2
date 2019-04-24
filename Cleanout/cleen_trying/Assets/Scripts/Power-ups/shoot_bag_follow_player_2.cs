using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_bag_follow_player_2 : MonoBehaviour
{
    
    public GameObject player2_Move;
    public Transform weapons_Position;



    private void Start()
    {
        weapons_Position = player2_Move.transform;
    }
    void Update()
    {
        transform.position = new Vector3(weapons_Position.position.x + 2  , weapons_Position.position.y + 2,
             transform.position.z);
    }
}
