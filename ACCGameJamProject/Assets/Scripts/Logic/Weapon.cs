using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon 
{
    public static Weapon playerWeapon;
    public abstract Projectile Projectile{get;}
    public abstract float TimeBetweenShots{get;}
    public bool isFiring;
}
