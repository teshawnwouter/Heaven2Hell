using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class EnemyBehavour : Characters
{

    //public  CharacterStats playerSO;
    protected override void Awake()
    {
        base.Awake();
        gameObject.tag = "Enemy";
    }
    
    void Start()
    {
       
    }

    void Update()
    {
        
    }

    //private void OnDestroy()
    //{
    //    playerSO.experience += _experienceGiven;
        

    //}



}
