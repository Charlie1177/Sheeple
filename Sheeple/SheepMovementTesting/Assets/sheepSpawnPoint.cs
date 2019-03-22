using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheepSpawnPoint : MonoBehaviour
{

    public float spawnTime = 10f;
    public float spawnDelay = 10f;

    public GameObject[] Enemy;

    public Vector3 enposition;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Update", spawnDelay, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        int enemyIndex = Random.Range(0, Enemy.Length);
        Instantiate(Enemy[enemyIndex], enposition, transform.rotation);
    }
}
