using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTime = 10f;
    public Transform[] spawnPoints;
    public int enemyCount;
    public float time;

    void Start()
    {
        StartCoroutine(SpawnEnemyTimer(spawnTime));
    }


    

    IEnumerator SpawnEnemyTimer(float time)
    {
        Debug.Log("funciona2");
        yield return new WaitForSeconds(time);
        Spawn();
        StartCoroutine(SpawnEnemyTimer(spawnTime));

        void Spawn()
        {
            Debug.Log("funciona");
            int spawnPointIndex = UnityEngine.Random.Range(0, spawnPoints.Length);
            if (enemyCount < 3)
            {
                Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
                enemyCount++;
            }
        }
    }
}



