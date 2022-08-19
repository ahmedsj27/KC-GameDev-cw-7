using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gamecontroller : MonoBehaviour
{
    public Transform spawn;
    public Transform spawnR;
    public Transform spawnL;

    public GameObject enemy;

    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnenemy", 0f, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnenemy()
    {
        int randNum = Random.Range(1, 4);
        if (randNum == 1)
        {
            Instantiate(enemy, spawnL);

        }
        else if (randNum == 2)
        {
            Instantiate(enemy, spawn);

        }
        else
        {
            Instantiate(enemy, spawnR);

        }
    }

   
}
