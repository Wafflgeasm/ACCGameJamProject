using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapons{
    public class BFLWeapon : Weapon
    {
        public override Projectile Projectile => new Projectiles.BFLProjectile();
        public override float TimeBetweenShots => 1f;
    }
}
