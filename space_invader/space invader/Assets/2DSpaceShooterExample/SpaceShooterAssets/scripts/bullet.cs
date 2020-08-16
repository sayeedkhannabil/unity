using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed=5f;
    private Rigidbody2D rb2;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2=GetComponent<Rigidbody2D>();
        //rb2.velocity.y = speed;
        //rb2.velocity = new Vector2(0.0f, speed*Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        rb2.velocity = new Vector2(0f, speed);
    }
    
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
