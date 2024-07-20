using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    BulletType bulletType;
    public float proSpeed = 50f;

    Camera cam;

    public float damageZoneRadius = 6f;

    public GameObject normObj, spreadObj, explosiveObj, multiShot, ZoneObj;
   


   [SerializeField]private Transform firePoint;



    public float bulletSpread = 3f;

    public float fireDelay = 5f;

    bool readyToFire = true;


    void Start()
    {
        cam = Camera.main;

        bulletType = BulletType.normal;

        normObj.GetComponent<Bullet>().BulletSpeed = proSpeed;
        spreadObj.GetComponent<Bullet>().BulletSpeed = proSpeed;
        explosiveObj.GetComponent<Explosion>().BulletSpeed = proSpeed;
        multiShot.GetComponent<Bullet>().BulletSpeed = proSpeed;
    }


    void Update()
    {
        if (bulletType == BulletType.normal && readyToFire == true)
        {
            Projectile(normObj, 0f, true);
        }
        else if (bulletType == BulletType.spreads && readyToFire == true)
        {
            spreadObj.GetComponent<Bullet>().BulletSpeed = proSpeed - 3;
            Projectile(spreadObj, -bulletSpread, false);
            spreadObj.GetComponent<Bullet>().BulletSpeed = proSpeed;
            Projectile(spreadObj, 0f, false);
            spreadObj.GetComponent<Bullet>().BulletSpeed = proSpeed - 3;
            Projectile(spreadObj, bulletSpread, true);
            spreadObj.GetComponent<Bullet>().BulletSpeed = proSpeed;
            //50spread is the max spread we can use
            //make more spread and more bullets per spread

        }
        else if (bulletType == BulletType.explosive && readyToFire == true)
        {
            Projectile(explosiveObj, 0f, true);
        }
        else if (bulletType == BulletType.zone && readyToFire == true)
        {
           ZoneControle(ZoneObj,true);   
        }
        else if (bulletType == BulletType.multiShot && readyToFire == true)
        {
            Projectile(multiShot,180f,true);
            Projectile(multiShot,0f,true);
            Projectile(multiShot, 90, true);
            Projectile(multiShot,270,true);

        //calculate how to make more angels and more projetiles
        }   

    }



    public void Projectile(GameObject obj, float rotate, bool reset)
    {
        readyToFire = false;
        firePoint.Rotate(0f, rotate, 0f);
        GameObject projectile = Instantiate(obj, firePoint.position, firePoint.rotation);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        Vector3 forceDirection = firePoint.transform.forward;
        firePoint.Rotate(0f, -rotate, 0f);
        if (reset)
            Invoke(nameof(ResetShot), fireDelay);
    }

    public void ZoneControle(GameObject obj , bool reset)
    {
        readyToFire = false;


        var (sucess, position) = GetComponent<PlayerBehavour>().GetMouseInfo();


        if (sucess)
        {
            var direction = position - transform.position;
            direction.y = 0f;

            GameObject damagerZone = Instantiate(ZoneObj, direction, transform.rotation);
            Destroy(damagerZone, .5f);

            Collider[] PainZone = Physics.OverlapSphere(direction, damageZoneRadius);
            foreach (var c in PainZone)
            {
                EnemyBehavour enemyBehavour = c.GetComponent<EnemyBehavour>();
                if (enemyBehavour != null)
                {
                    enemyBehavour.GetComponent<EnemyBehavour>().TakeDamage(20);
                    //Take damage
                }
            }
        }
        if (reset)
            Invoke(nameof(ResetShot), fireDelay);
        //make a zone around your mouse posisiton
        //let it do damager by creating a zone and destroying it 
        // call the damage function
    }

    private void ResetShot()
    {
        readyToFire = true;
    }

}
