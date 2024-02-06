using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTo : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    Vector2 targetPos;
    // Start is called before the first frame update


    void Start()
    {
        targetPos = new Vector2(0.0f, 0.0f);
        Vector2 lookDirection = targetPos - GetComponent<Rigidbody2D>().position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        GetComponent<Rigidbody2D>().rotation = angle;
    }
    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;
    }


}
