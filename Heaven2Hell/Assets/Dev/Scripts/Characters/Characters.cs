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

    [Header("XP")]
    public int _experienceGiven;
    public int _experience;
    public int _level;
    protected virtual void Awake()
    {
        _health = stats.health;
        _armor = stats.armor;
        _attack = stats.damage;
        _speed = stats.movespeed;
        _experience = stats.experience;
        _experienceGiven = stats.experienceGiven;
        _level = stats.level;
    }
}
