using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavour : MonoBehaviour
{
    [Header("Movement")]
    private float moveSpeed = 20f;
    private Rigidbody playerRb;


    [Header("aiming and camera")]
    private Camera cam;
    [SerializeField] LayerMask GroundMask;


    void Start()
    {
        cam = Camera.main;

        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Aim();
    }
    private void FixedUpdate()
    {
        float movementUpAndDown = Input.GetAxis("Horizontal") * moveSpeed;
        float movementLeftAndRight = Input.GetAxis("Vertical") * moveSpeed;

        playerRb.velocity = new Vector3(movementUpAndDown,0, movementLeftAndRight);


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
