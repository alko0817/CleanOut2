using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_fire : MonoBehaviour
{
    public GameObject Fire_ ;
    public GameObject Animals_ ;
    public GameObject shield;
    public Transform[] SpawnPoints;
   // public Transform[] SpawnAnimals;
    public Transform[] SpawnShield;

    void Start()
    {
        InvokeRepeating("Spawn_Fire", 10, 20);
        //InvokeRepeating("Spawn_Enemies", 1 , 15);
        InvokeRepeating("Spawn_Shield", 8, 25);

    }

    void Spawn_Fire()
    { 
        int spawnIndex = Random.Range(0, SpawnPoints.Length);
        Instantiate(Fire_, SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);
    }


    /*void Spawn_Enemies()
    {
        int spawnIndex = Random.Range(0, SpawnAnimals.Length);
         Instantiate(Animals_, SpawnAnimals[spawnIndex].position, SpawnAnimals[spawnIndex].rotation);

    }*/

    void Spawn_Shield()
    {
        int spawnIndex = Random.Range(0, SpawnShield.Length);
        Instantiate(shield, SpawnShield[spawnIndex].position, SpawnShield[spawnIndex].rotation);

    }
}
