using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Notes: Speed Variable changes movement speed of Object.
// Stopping Distance variable changes distance in which moving object stops from target.

public class sheepMove : MonoBehaviour
{
    
    public float speed;
    public float stoppingDistance;
    //public string whichNPC;


    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Farmer").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
