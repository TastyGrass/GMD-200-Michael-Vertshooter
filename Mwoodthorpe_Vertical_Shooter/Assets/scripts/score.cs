using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{

    public int scoreVal;
    public TMP_Text gameScore;

    // Update is called once per frame
    private void Start()
    {
        if (gameObject.CompareTag("Planet"))
        {
            scoreVal = 0;
        }
        else
        {
            scoreVal = MainManager.Instance.score;
        }
        
    }
    void Update()
    {
        gameScore.SetText("Score: " + scoreVal);
    }
}
