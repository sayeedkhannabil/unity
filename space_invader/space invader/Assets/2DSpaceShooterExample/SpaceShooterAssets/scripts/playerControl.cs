using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class playerControl : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public GameObject bulletPrefav;
    private Vector2 bulletPos;
    public float fireRate = 0.05f;
    private float nextFire = 0.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate ()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (Input.GetButtonDown("Fire1") && Time.time > nextFire) {
            shoot();
        }
    }

    void shoot()
    {
        bulletPos = transform.position;
        
        bulletPos += new Vector2(0.0f, 1f);
        Instantiate(bulletPrefav, bulletPos, Quaternion.identity);
    }
}
