using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "UnitStats")]
public class CharacterStats : ScriptableObject
{
    //public Dictionary<CharacterStats, float> stats = new Dictionary<CharacterStats, float>();

    public  int health ;
    public int armor;
    public int damage;
    public int movespeed;
        
    [System.NonSerialized] public UnityAction<int> healthChanged;
   
}
