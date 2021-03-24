using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public Transform[] SpawnPoints;
    public GameObject[] ballons;


    //Spawn Baloons
    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(4);

        for (int i = 0; i < 3; i++)
        {
            Instantiate(ballons[i], SpawnPoints[i].position, Quaternion.identity);
        }

        StartCoroutine(StartSpawning());
    }

    void Start()
    {
        StartCoroutine(StartSpawning());
    }

}
