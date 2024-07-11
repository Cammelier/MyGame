using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float spawnCD = 1.5f, spawnHeight = 1.5f;

    public GameObject obstaclePrefab;

    float timer;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SpawnObstacle();
    }

    void SpawnObstacle()
    {
        if (timer <= 0)
        {
            GameObject newOb = Instantiate(obstaclePrefab);
            newOb.transform.position = transform.position + new Vector3(0, Random.Range(-spawnHeight, spawnHeight), 0);
            timer = spawnCD;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}