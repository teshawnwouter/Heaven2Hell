using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Upgrades")]
public class CharacterUpgrades : ScriptableObject
{
     Dictionary<CharacterStats, float> stats = new Dictionary<CharacterStats, float>();

    public string itemUpgrade;
    public int health;
    public int armor;
    public int damage;
    public int movespeed;
}
