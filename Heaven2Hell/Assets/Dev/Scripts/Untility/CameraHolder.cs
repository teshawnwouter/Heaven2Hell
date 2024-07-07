using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    [SerializeField] private Transform targert;
    private GameObject player;
    [SerializeField] private Vector3 offSet;

    private float followSpeed;

    void Start()
    {
        player = GameObject.FindWithTag("Player");

        if (player.CompareTag("Player"))
        {
           targert = player.GetComponent<Transform>();
        }
        followSpeed = 10f;
    }
    void Update()
    {
        FollowPlayer();
    }
    private void FollowPlayer()
    {
        if (targert != null)
        {
            transform.position = Vector3.Lerp(transform.position, targert.position + offSet, followSpeed * Time.deltaTime);

        }
        else
        {
            return;
        }
    }

}
