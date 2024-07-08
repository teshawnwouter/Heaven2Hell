using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Characters : MonoBehaviour
{
    
    public CharacterStats stats;
    [Header("stats")]
    public int _armor;
    public int _health;
    public int _attack;
    public int _speed;
    protected virtual void Awake()
   {
        _health = stats.health;
        _armor = stats.armor;
        _attack = stats.damage;
        _speed = stats.movespeed;
       
       
   }
    
    protected virtual void TakeDamage( int playerHealthPoints)
    {
        
    }


    protected virtual void DoDamager()
    {

    }
}
