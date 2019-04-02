using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
   
    [HideInInspector]
    public float health = 100;
    

    [Header("Unity Stuff")]
    public Image healthbar;

    void Start()
    {
        
    }

    /*void OnCollisionEnter2D(Collision2D collision)
    { 
        float damage = 0;
        health -= damage;
        health = health / 100f;
        healthbar.fillAmount = health;
    }*/

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "pain")
        Debug.Log("Entered"); 
        float damage = 15;
        health -= damage;
        health = health / 100f;
        healthbar.fillAmount = health;
    }
}
