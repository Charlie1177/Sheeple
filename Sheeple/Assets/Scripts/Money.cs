
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
        money = 100;
        moneyCount.text = money.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        tics = tics + Time.deltaTime;
       
        if (tics >= 1)
        {
            money++;
            moneyCount.text = money.ToString();
            tics = 0;
        }

        /*if(hours >= 12)
        {
            hours = 0;
            if(apm == "AM")
            {
                apm = "PM";
                Cycle.text = apm.ToString();

            }else if(apm == "PM"){

                apm = "AM";
                Cycle.text = apm.ToString();
            }
        }*/

           //This if or assigning times
        //Hoursul.text = DateFetcher.Hour.ToString();
        //Minutestul.text = DateFetcher.Minute.ToString();
        //Secondsul.text = DateFetcher.Second.ToString();
        //print("print:" + DateFetcher);
    }
}
