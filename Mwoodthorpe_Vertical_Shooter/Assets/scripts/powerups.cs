using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerups : MonoBehaviour
{

    public bool pow1 = false;
    public bool pow2 = false;
    public bool pow3 = false;
    public float timer1 = 15f;
    public float timer2 = 30f;
    public float timer3 = 20f;
    public GameObject multiShot;
    public bool pow1Active = false;
    public bool pow2Active = false;
    public bool pow3Active = false;

    // Update is called once per frame

    public void PowCollect(int powNum)
    {
        if (powNum == 1)
        {
            if (pow1 == false)
            {
                timer1 = 10f;
                pow1 = true;
                multiShot.SetActive(true);
                pow1Active = true;
            }
        }
        else if (powNum == 2)
        {
            if (pow2 == false)
            {
                pow2 = true;
                //powerup effect
            }
        }
        else
        {
            if (pow3 == false)
            {
                pow3 = true;
                //powerup effect 
            }
        }
    }

    void Update()
    {
        timer1 -= Time.deltaTime;

        if (timer1 <= 0.0f)
        {
            if (pow1 == true)
            {
                timerEnded();
            }


        }

        timer2 -= Time.deltaTime;

        if (timer2 <= 0.0f)
        {

            if (pow2 == true)
            {
                timer2Ended();
            }


        }

        timer3 -= Time.deltaTime;

        if (timer3 <= 0.0f)
        {
            if (pow3 == true)
            {
                timer3Ended();
            }
        }

    }

    void timerEnded()
    {
        pow1 = false;
        multiShot.SetActive(false);
        pow1Active = false;
    }
    void timer2Ended()
    {
        pow2 = false;               
    }

    void timer3Ended()
    {
        pow3 = false;
    }

   
}
