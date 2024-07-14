using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : BulletBase  
{
    EnemyBehavour enemyBehavour;
    private Rigidbody rb;

    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody>();
        enemyBehavour = GetComponent<EnemyBehavour>();
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
            enemyBehavour.GetComponent<EnemyBehavour>().TakeDamage(10);
            //figure out why the damage script from the enemy is not working for the bullet
        }
        Destroy(gameObject);
    }
}
