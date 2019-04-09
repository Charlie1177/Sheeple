using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepSpawn : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject sheep;
    public float spawnTime = 1f;
    public float spawnDelay = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("addSheep", spawnDelay, spawnTime);
    }

    void addSheep()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        

        Instantiate(sheep, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
