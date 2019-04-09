using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
   
    [HideInInspector]
    public float health = 100;
    private float temp;
    public float regenDelay = .5f;
    public float regenTime = 4f;

    [Header("Unity Stuff")]
    public Image healthbar;

    void Start()
    {
        //begin calling the regen function
        InvokeRepeating("reigen", regenDelay, regenTime);
    }

    //regeneration fuction
    void reigen()
    {
        //if health is under 100 then begin to regen health
        if(health < 100)
        {
            //calculations for regen health
            health = health / 100;
            health += .1f;
            health = health * 100;
            //check final health is back to whole integer
            Debug.Log(health);
        }
    }

    

    void OnTriggerEnter2D(Collider2D col)
    {
        //reports health
        Debug.Log(health);
        //checks if object collided with has tag pain
        if(col.tag == "pain")
        //reports collision
        Debug.Log("Entered"); 
        float damage = 15;
        //caluclate damage
        health -= damage;
        //report new health
        Debug.Log(health);
        //set temp to health
        temp = health;
        //more health calculations and setting healthbar.fillamount to new damage
        health = health / 100f;
        healthbar.fillAmount = health;
        //restore health to nondecimal state
        health = temp;
        //report health final time
        Debug.Log(health);
    }
}
