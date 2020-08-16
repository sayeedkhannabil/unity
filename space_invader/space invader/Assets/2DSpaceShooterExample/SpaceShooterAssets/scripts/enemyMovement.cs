using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    private Vector3 pos1;
    private Vector3 pos2;
    private float yAxis = 5f;
    public float speed = 0.3f;
    
    private Vector2 screenBounds;

    private float objectWidth;

    private float objectHeight;

    private void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
        pos1 = new Vector3(screenBounds.x * -1 + objectWidth, yAxis,0);
        pos2 = new Vector3(screenBounds.x - objectWidth, yAxis,0);
    }

    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
        yAxis -= 0.003f;
        pos1 = new Vector3(screenBounds.x * -1 + objectWidth, yAxis,0);
        pos2 = new Vector3(screenBounds.x - objectWidth, yAxis, 0);
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "bullet") {
            Destroy(other.gameObject);
        }
    }
}   

