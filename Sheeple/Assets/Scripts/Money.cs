
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Money : MonoBehaviour
{
   
    public int money;
    public Text moneyCount;
    public float tics;
    // Start is called before the first frame update
    void Start()
    {
        tics = 0;
        money = 30;
        moneyCount.text = money.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        tics = tics + Time.deltaTime;
       
        if (tics >= 2)
        {
            money += 5;
            moneyCount.text = money.ToString();
            tics = 0;
        }
    }
}
