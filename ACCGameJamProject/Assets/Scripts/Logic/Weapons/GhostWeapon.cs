using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapons{
    public class GhostWeapon : Weapon
    {
        public override Projectile Projectile => new Projectiles.GhostProjectile();
        public override float TimeBetweenShots => 1f;
    }
}
