using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BFLWeapon : Weapon
{
    public override Projectile Projectile => new BFLProjectile(15);
    public override float TimeBetweenShots => 1f;
}
