using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : BulletBase  
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * BulletSpeed;
    }

    private void Update()
    {
        Destroy(gameObject, 5f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("testig");
        Destroy(gameObject);
    }
}
