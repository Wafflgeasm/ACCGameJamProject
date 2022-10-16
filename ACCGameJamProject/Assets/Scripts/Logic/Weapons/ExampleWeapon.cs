using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleWeapon : Weapon
{
    public override Projectile Projectile => throw new System.NotImplementedException();
    public override float TimeBetweenShots => throw new System.NotImplementedException();
}
