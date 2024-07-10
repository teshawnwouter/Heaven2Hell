using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class EnemyBehavour : Characters
{

    public  CharacterStats playerSO;
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
    public void TakeDamage(int playerHealthPoints)
    {
        if (_health > 0)
        {
            _health -= playerHealthPoints;
        }
        else
        {
            if(gameObject!=null)
            {
                playerSO.experience += _experienceGiven;
                Destroy(gameObject);
            }
        }
    }



}
