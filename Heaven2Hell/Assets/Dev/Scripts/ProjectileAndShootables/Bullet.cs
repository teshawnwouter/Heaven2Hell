using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : BulletBase  
{
   
    private Rigidbody rb;

    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * BulletSpeed;
    }

    protected virtual void Update()
    {
        Destroy(gameObject, BulletDuration);
    }
    protected virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("testig");
            collision.gameObject.GetComponent<EnemyBehavour>().TakeDamage(10);
        }
        Destroy(gameObject);
    }
}
