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

    [SerializeField] private int health =  200;
    [SerializeField]private int armor = 50;
    [SerializeField] private int damage = 20;
    [SerializeField] private int movespeed = 5;

    private int activeHealth;
        
    [System.NonSerialized] public UnityAction<int> healthChanged;


    public int Health { 
        get { return activeHealth; } 
        set {  if(value != activeHealth)
            {
                activeHealth = Mathf.Max(value, 0);
                healthChanged?.Invoke(activeHealth);
            }
        }
    }



    public void InitDefaulds()
    {
        Health = health;
    }
   
}
