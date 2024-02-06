using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class Laser : MonoBehaviour
{

    [SerializeField] private float speed = 10f;
    [SerializeField] private float lifeTime = 1f;
    private float life = 0f;
    public int powerupChance = 5;
    private float powerupNum;
    public GameObject planet;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;
    }

    private void Awake()
    {
        planet = GameObject.FindGameObjectWithTag("Planet");
    }

    // Update is called once per frame
    void Update()
    {
        life += Time.deltaTime;
        if (life >= lifeTime)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        powerupNum = Random.Range(1, powerupChance);
        if (powerupNum == 1)
        {
            
            if (other.CompareTag("Enemy"))
            {
                other.gameObject.GetComponent<enemy>().Respawn();
                //other.gameObject.GetComponent<enemy>().SpawnPowerup();
                Destroy(gameObject);
                planet.GetComponent<score>().scoreVal += 10;


            }
            else if (other.CompareTag("Enemy 2"))
            {
                other.gameObject.GetComponent<enemy2>().Respawn();
                other.gameObject.GetComponent<enemy2>().SpawnPowerup();
                Destroy(gameObject);
                planet.GetComponent<score>().scoreVal += 50;
            }
            else if (other.CompareTag("Enemy 3"))
            {
                other.gameObject.GetComponent<enemy3>().Respawn();
                other.gameObject.GetComponent<enemy3>().SpawnPowerup();
                Destroy(gameObject);
                planet.GetComponent<score>().scoreVal += 100;
            }
        }
        else
        {
            if (other.CompareTag("Enemy"))
            {
                other.gameObject.GetComponent<enemy>().Respawn();             
                Destroy(gameObject);
                planet.GetComponent<score>().scoreVal += 10;
            }
            else if (other.CompareTag("Enemy 2"))
            {
                other.gameObject.GetComponent<enemy2>().Respawn();
                Destroy(gameObject);
                planet.GetComponent<score>().scoreVal += 50;
            }
            else if (other.CompareTag("Enemy 3"))
            {
                other.gameObject.GetComponent<enemy3>().Respawn();
                Destroy(gameObject);
                planet.GetComponent<score>().scoreVal += 100;
            }
        }
       
        
    }
}
