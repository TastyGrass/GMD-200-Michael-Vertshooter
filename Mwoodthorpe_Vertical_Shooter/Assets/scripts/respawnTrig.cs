using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnTrig : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<enemy>().Respawn();
        }
        else if (other.gameObject.CompareTag("Enemy 2"))
        {
            other.gameObject.GetComponent<enemy2>().Respawn();
        }
        else if (other.gameObject.CompareTag("Enemy 3"))
        {
            other.gameObject.GetComponent<enemy3>().Respawn();
        }
        else if (other.gameObject.CompareTag("Powerup1"))
        {
            other.gameObject.GetComponent<collect>().Collected(1);
        }
    }
}
