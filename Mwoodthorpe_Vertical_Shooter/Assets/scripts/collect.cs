using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{

    private Vector2 spawnPos;
    public GameObject events;


    private void Awake()
    {
        events = GameObject.FindGameObjectWithTag("Planet");
    }

    public void SpawnP_Up(Vector2 spawnPosition)
    {
        Vector2 spawnPos = spawnPosition;
        Instantiate(gameObject, spawnPosition, Quaternion.identity);
        
    }
   public void Collected(int powNum)
    {
        int powerNum = powNum;
        Destroy(gameObject);
        events.GetComponent<powerups>().PowCollect(powerNum);//add to each specific powerup value
    }
}
