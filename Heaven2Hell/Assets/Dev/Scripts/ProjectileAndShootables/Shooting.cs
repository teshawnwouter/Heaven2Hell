using UnityEngine;
using UnityEngine.UIElements;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    BulletType bulletType;
    public float proSpeed = 50f;

    public GameObject normObj, spreadObj, explosiveObj, multiShot;



   [SerializeField]private Transform firePoint;



    public float bulletSpread = 3f;

    public float fireDelay = 5f;

    bool readyToFire = true;


    void Start()
    {
        bulletType = BulletType.normal;

        normObj.GetComponent<Bullet>().BulletSpeed = proSpeed;
        spreadObj.GetComponent<Bullet>().BulletSpeed = proSpeed;
        explosiveObj.GetComponent<Bullet>().BulletSpeed = proSpeed;
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
        }
        else if (bulletType == BulletType.explosive && readyToFire == true)
        {

        }
        else if (bulletType == BulletType.zone && readyToFire == true)
        {

        }
        else if (bulletType == BulletType.multiShot && readyToFire == true)
        {
            multiAttack(multiShot,0f,true);
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


    public void ZoneControle()
    {

    }

    public void multiAttack(GameObject obj, float rotate, bool reset)
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

    private void ResetShot()
    {
        readyToFire = true;
    }

}
