﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnimalMove : MonoBehaviour
{
    
    //spped and other variables
    public float speed = 1.5f;
    private Vector3 target;
    private bool moved = false;
    private bool arrived = false;
    private int kills = 0;
    public int vanish;

    void Start()
    {
        target = transform.position;
    }

    void Update()
    {
        if(arrived == false)
        {
            //check if the mouse button has been clicked
            if (Input.GetMouseButtonDown(0) && moved == false)
            {
                moved = true;
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                target.z = transform.position.z;
            }
            if (arrived == false)
                transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            
        }
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pain")
        {
            Destroy(collision.gameObject);
        }
        kills++;
        if(kills == vanish)
        {
            Destroy(gameObject);
        }
    }

    

}