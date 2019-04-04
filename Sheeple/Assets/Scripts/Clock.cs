
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;



public class Clock : MonoBehaviour
{
        

    public int DateFetcher;
    public int hours;
    public Text Hoursul, Minutestul, Secondsul, Cycle;
    public float tics;
    public string apm;
    // Start is called before the first frame update
    void Start()
    {
        tics = 0;
        hours = 5;
        apm = "AM";
        Hoursul.text = hours.ToString();
        Cycle.text = apm.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        tics = tics + Time.deltaTime;
       
        if (tics >= 4)
        {
            hours++;
            Hoursul.text = hours.ToString();
            tics = 0;
        }

        if(hours >= 12)
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
        }

           //This if or assigning times
        //Hoursul.text = DateFetcher.Hour.ToString();
        //Minutestul.text = DateFetcher.Minute.ToString();
        //Secondsul.text = DateFetcher.Second.ToString();
        //print("print:" + DateFetcher);
    }
}
