using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Projectiles{
    public class GhostProjectile : Projectile
    {
        public override int InitialDamage => 30;
        public override float InitialSpeed => 5f;
        public override float InitialSize => 0.5f;
        public override GameObject Prefab => AssetSource.instance.gameObjects.projectiles.ghost;
    }
}
