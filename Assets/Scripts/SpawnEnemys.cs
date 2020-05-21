using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemys : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] spawnPoints;

    public int howoften = 10;
    public int howmany = 3;
    public float etimer;
    public GameObject enemy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        etimer = etimer - Time.deltaTime;
        if (etimer < 0)
        {
            etimer = howoften;

            int i = howmany;
            while (i > 0)
            {
                i--;

                int spawnPointIndex = Random.Range(0, spawnPoints.Length);

                Instantiate(enemy,
                            spawnPoints[spawnPointIndex].position,
                            spawnPoints[spawnPointIndex].rotation);
            }
        }
    }
}

