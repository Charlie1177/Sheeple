﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductivityBar : MonoBehaviour
{

    [HideInInspector]
    public float health = 0;
    private float temp;

    [Header("Unity Stuff")]
    public Image productivitybar;

    void Start()
    {

    }



    void OnTriggerEnter2D(Collider2D col)
    {
        //reports health
        Debug.Log(health);
        //checks if object collided with has tag pain
        if (col.tag == "pain")
            //reports collision
            Debug.Log("Entered");
        float damage = 15;
        //caluclate damage
        health += damage;
        //report new health
        Debug.Log(health);
        //set temp to health
        temp = health;
        //more health calculations and setting healthbar.fillamount to new damage
        health = health / 100f;
        productivitybar.fillAmount = health;
        //restore health to nondecimal state
        health = temp;
        //report health final time
        Debug.Log(health);
    }
}
