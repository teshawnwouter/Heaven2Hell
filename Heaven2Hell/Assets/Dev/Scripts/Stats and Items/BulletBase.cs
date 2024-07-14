using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum BulletType { normal, explosive, zone, spreads , multiShot}
public class BulletBase : MonoBehaviour
{
    protected float explotionRadios = 10f;


    public float BulletSpeed;

    protected float BulletDamage;


    protected float BulletDuration = .5f;



}
