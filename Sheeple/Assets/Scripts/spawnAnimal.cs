using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Notes: Object to spawn can be selected from Unity Inspector. Attach to Camera.

public class spawnAnimal : MonoBehaviour
{
    public GameObject objectToSpawn;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            spawnPosition.z = 0.0f;
            GameObject objectInstance = Instantiate(objectToSpawn, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
        }
    }
}
