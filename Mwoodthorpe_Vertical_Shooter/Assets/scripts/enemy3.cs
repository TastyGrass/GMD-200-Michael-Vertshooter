using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3 : MonoBehaviour
{
    public Vector2 respawnMax;
    public Vector2 respawnMin;
    private Rigidbody2D rb;
    [SerializeField] public GameObject target;
    Vector2 targetPos;
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float rotateSpeed = 10f;
    public float timer2 = 2f;
    private bool moveSwap = false;
    public GameObject powerup1;
    public GameObject powerup2;
    public GameObject powerup3;
    private int choosePow;
    Vector2 powSpawn;
    public GameObject events;

    // Start is called before the first frame update
    void Start()
    {
        events = GameObject.FindGameObjectWithTag("Planet");
        targetPos = target.transform.position;
        GetComponent<Rigidbody2D>().velocity = transform.up * moveSpeed;
        GetComponent<Rigidbody2D>().velocity = transform.right * moveSpeed;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Respawn()
    {
        gameObject.SetActive(true);
        Vector2 randPos = new Vector2(Random.Range(respawnMin.x, respawnMax.x), Random.Range(respawnMin.y, respawnMax.y));
        transform.position = randPos;
        rb.velocity = Vector2.zero;

    }
    private void Update()
    {

        timer2 -= Time.deltaTime;

        if (timer2 <= 0.0f)
        {
            if (moveSwap == true)
            {
                moveSwap = false;
                rotateSpeed *= -1;
                timer2 = 2f;
            }
            else if (moveSwap == false)
            {
                moveSwap = true;
                rotateSpeed *= -1;
                timer2 = 2f;
            }
        }
        Vector2 lookDirection = targetPos - rb.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
        GetComponent<Rigidbody2D>().velocity = transform.up *  moveSpeed;
        GetComponent<Rigidbody2D>().AddForce(transform.right * rotateSpeed);
        
    }

    public void SpawnPowerup()
    {
        choosePow = 1;
        if (choosePow == 1 && events.GetComponent<powerups>().pow1Active != true)
        {

            powSpawn = new Vector2(rb.position.x, rb.position.y);
            powerup1.GetComponent<collect>().SpawnP_Up(powSpawn);
        }
    }
}

