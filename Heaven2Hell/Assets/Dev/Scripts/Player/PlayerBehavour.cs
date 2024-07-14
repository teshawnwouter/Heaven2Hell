using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavour : Characters
{
    [Header("Movement")]
    private Rigidbody playerRb;


    [Header("aiming and camera")]
    private Camera cam;
    [SerializeField] LayerMask GroundMask;

    

    public EnemyBehavour enemyBehavour;

    protected override void Awake()
    {
        gameObject.tag = "Player";

        base.Awake();
    }
    void Start()
    {
        
        cam = Camera.main;

        playerRb = GetComponent<Rigidbody>();

       
    }
    void Update()
    {
        PlayerWalking();
        Aim();
      
        if(Input.GetKeyDown(KeyCode.R))
        {
            enemyBehavour.TakeDamage(50);
            Debug.Log(enemyBehavour._health);
        }

        if(stats.experience != _experience)
        {
            _experience = stats.experience;
        }
    }
   

    private void PlayerWalking()
    {
        float forwardAndBack = Input.GetAxis("Horizontal");
        float LeftAndRight = Input.GetAxis("Vertical");
        Vector3 moving = new Vector3(forwardAndBack,0,LeftAndRight);
        transform.Translate(moving * _speed * Time.deltaTime, Space.World);
    }

    private (bool sucess, Vector3 position) GetMouseInfo()
    {
        var ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;


        if(Physics.Raycast(ray,out hitInfo, Mathf.Infinity, GroundMask))
        {
           return(sucess:true, position:hitInfo.point);

        }
        else
        {
            return (sucess: false, position: Vector3.zero);
        }
    }


    private void Aim()
    {
        var (sucess, position) = GetMouseInfo();
        if (sucess)
        {
            var direction = position - transform.position;

           direction.y = 0;

            transform.forward = direction;
       }
    }
}
