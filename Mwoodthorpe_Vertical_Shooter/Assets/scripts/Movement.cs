using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector2 input;
    public Camera camera;
    public float turnRate;
    //[SerializeField] private Vector2 movespeed;
    //[SerializeField] private float boundsLeft = 0;
    //[SerializeField] private float boundsRight = 0;
    ///[SerializeField] private float boundsUp = 0;
    //[SerializeField] private float boundsDown = 0;
    private Rigidbody2D rb;
    //[SerializeField] private float rotateSpeed = 60;
    Vector2 mousePos;

    private void Awake()
    {
        rb =  GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        mousePos = camera.ScreenToWorldPoint(Input.mousePosition);

        Vector2 lookDirection = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f - (turnRate);
        rb.rotation = angle;
        //input = new Vector2(x:Input.GetAxis("Horizontal"), y:Input.GetAxis("Vertical")) ;
    }

    private void FixedUpdate()
    {
        //rb.velocity = input * movespeed;
        //Vector2 position = (Vector2)transform.position;
        //position.x = Mathf.Clamp(position.x, boundsLeft, boundsRight);
        //position.y = Mathf.Clamp(position.y, boundsDown, boundsUp);
        //transform.position = (Vector2)position;

    }
}
