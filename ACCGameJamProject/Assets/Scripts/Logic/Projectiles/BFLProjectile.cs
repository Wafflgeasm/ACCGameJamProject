using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Projectiles{
    public class BFLProjectile : Projectile
    {
        public override int InitialDamage => 55;
        public override float InitialSpeed => 5f;
        public override float InitialSize => 1f;
        public override GameObject Prefab => AssetSource.instance.gameObjects.projectiles.bfl;
        public override int InitialPiercesLeft => 2;
    }
}
