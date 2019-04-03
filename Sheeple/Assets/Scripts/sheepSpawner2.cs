using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 User Notes:
 In the Unity Inspector, be sure to assign the public values correctly, or else this will not work. Here
 are the values and what they mean.

    Spawn Points:
        Size: Enter any number 1 or higher, and for each element establish an object. These objects assigned
              are where the enemy will be spawning from.
        Element: These are the objects selected to be the spawn points.

    Enemy: This is the object that will be spawned at the assigned spawn points.

    Spawn Time: This is the number of seconds that the enemy will be spawned. (3 means every 3 seconds, 2 is every 2, etc.)

    Spawn Delay: How long it will take for the first enemy to spawn since script is initiated
*/

public class sheepSpawner2 : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject enemy;
    public float spawnTime = 5f;
    public float spawnDelay = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("addEnemy", spawnDelay, spawnTime);
    }

    void addEnemy()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
