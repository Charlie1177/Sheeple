using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artist : MonoBehaviour
{
    float smooth = 5.0f;
    float tiltangle = 90.0f;

    public float speed = 10f;
    private Transform target;
    private int wavepointIndex = 0;
    public GameObject refClock;
    public GameObject whichWaypoint;
    public Transform farmerSleep;

    

    void Start()
    {
        refClock.GetComponent<Clock>();

        target = ArtistPoints.points[0];
    
    }

    void Update()
    {
       //tics = tics + Time.deltaTime;
       Vector3 dir = target.position - transform.position;
        /*if(refClock.GetComponent<Clock>().hours == 7)
        {
            //this.transform.position = new Vector3(90);//set for a place to go to sleep               
            //??????????????????????????
        }*/
       transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        
       if(Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
        
    }

    void GetNextWaypoint()
    {
        if(wavepointIndex >= ArtistPoints.points.Length - 1)
        {
            wavepointIndex = -1;
        }

        wavepointIndex++;
        target = ArtistPoints.points[wavepointIndex];
    }
    
}
