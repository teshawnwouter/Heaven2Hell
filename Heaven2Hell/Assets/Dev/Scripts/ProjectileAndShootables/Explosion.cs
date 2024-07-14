using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : Bullet
{
    public GameObject sphereCheck;
   
    protected override void Start()
    {
        base.Start();
    }
 
    protected override void Update()
    { 
        base.Update();
    }

    protected override  void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);
        GameObject explosionZone = Instantiate(sphereCheck, transform.position, transform.rotation);
        Destroy(explosionZone,.03f);

        Collider[] splashZone = Physics.OverlapSphere(transform.position, explotionRadios);
        foreach (Collider c in splashZone)
        {
            EnemyBehavour enemyBehavour = c.GetComponent<EnemyBehavour>();
            if (enemyBehavour != null)
            {
                enemyBehavour.GetComponent<EnemyBehavour>().TakeDamage(20);
                //Take damage
            }
            Debug.Log("no enemeies");
        }
    }


    private void OnDestroy()
    {
        GameObject explosionZone = Instantiate(sphereCheck, transform.position, transform.rotation);
        Destroy(explosionZone, .03f);

        Collider[] splashZone = Physics.OverlapSphere(transform.position, explotionRadios);
        foreach (Collider c in splashZone)
        {
            EnemyBehavour enemyBehavour = c.GetComponent<EnemyBehavour>();
            if (enemyBehavour != null)
            {
                enemyBehavour.GetComponent<EnemyBehavour>().TakeDamage(20);
                //Take damage
            }
            Debug.Log("no enemeies");
        }
    }
}
