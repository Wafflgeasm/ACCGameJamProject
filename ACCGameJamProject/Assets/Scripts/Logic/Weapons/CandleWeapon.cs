using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapons{
    public class CandleWeapon : Weapon
    {
        public override Projectile Projectile => new Projectiles.CandleProjectile();
        public override float TimeBetweenShots => 1f;
    }
}
