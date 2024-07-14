using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum BulletType { normal, explosive, zone, spreads , multiShot}
public class BulletBase : MonoBehaviour
{
    public float explotionRadios;


    public float BulletSpeed;
    public float BulletDuration = 5;



}
