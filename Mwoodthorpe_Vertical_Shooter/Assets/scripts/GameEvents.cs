using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{

    [SerializeField] public GameObject enemy1one;
    [SerializeField] public GameObject enemy1two;
    [SerializeField] public GameObject enemy1three;
    [SerializeField] public GameObject enemy1four;
    [SerializeField] public GameObject enemy2one;
    [SerializeField] public GameObject enemy2two;
    [SerializeField] public GameObject enemy3one;
    [SerializeField] public GameObject enemy3two;
    public float timer1 = 15f;
    public float timer2 = 30f;
    public float timer3 = 20f;
    private bool phase2 = false;
    private bool phase3 = false;
    private bool phase4 = false;
 

    // Update is called once per frame
    void Update()
    {
        timer1 -= Time.deltaTime;

        if (timer1 <= 0.0f)
        {
            if (phase2 == false)
            {
                timerEnded();
            }
        
            
        }

        timer2 -= Time.deltaTime;

        if (timer2 <= 0.0f)
        {

            if (phase3 == false)
            {
                timer2Ended();
            }


        }

        timer3 -= Time.deltaTime;

        if (timer3 <= 0.0f)
        {
            if(phase4 == false)
            {
                timer3Ended();
            }        
        }

    }

    void timerEnded()
    {
        phase2 = true;
        enemy1one.SetActive(true);
        enemy1two.SetActive(true);
    }
    void timer2Ended()
    {
        phase3 = true;

        enemy2one.SetActive(true);
        enemy2one.SetActive(true);
    }

    void timer3Ended()
    {
        phase4 = true;
        enemy1three.SetActive(true);
        enemy1four.SetActive(true);
        enemy3one.SetActive(true);
        enemy3two.SetActive(true);
    }
}

