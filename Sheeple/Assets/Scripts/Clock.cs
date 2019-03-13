
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Clock : MonoBehaviour
{
    public int DateFetcher;
    public int hours;
    public Text Hoursul, Minutestul, Secondsul;
    public float tics;
    // Start is called before the first frame update
    void Start()
    {
        tics = 0;
        hours = 5;
        Hoursul.text = hours.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        tics = tics + Time.deltaTime;
       
        if (tics >= 10)
        {
            hours++;
            Hoursul.text = hours.ToString();
            tics = 0;
        }
           //This if or assigning times
        //Hoursul.text = DateFetcher.Hour.ToString();
        //Minutestul.text = DateFetcher.Minute.ToString();
        //Secondsul.text = DateFetcher.Second.ToString();
        //print("print:" + DateFetcher);
    }
}
