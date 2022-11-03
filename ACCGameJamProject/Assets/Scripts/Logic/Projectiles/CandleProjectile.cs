using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Projectiles{
    public class CandleProjectile : Projectile
    {
        public override int InitialDamage => 25;
        public override float InitialSpeed => 5f;
        public override float InitialSize => 0.25f;
        public override GameObject Prefab => AssetSource.instance.gameObjects.projectiles.candle;
    }
}
