using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "UnitStats")]
public class CharacterStats : ScriptableObject
{ 
    [Header("Stats")]
    public  int health ;
    public int armor;
    public int damage;
    public int movespeed;

    [Header("XP")]
    public int experienceGiven;
    public int experience;
    public int level;
        
    [System.NonSerialized] public UnityAction<int> healthChanged;
   
}
