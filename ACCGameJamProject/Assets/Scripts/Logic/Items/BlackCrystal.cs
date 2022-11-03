using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items{
    public class BlackCrystal : Item
    {
        public override string Name => LanguageAsset.instance.items.names.blackCrystal;
        public override Sprite Sprite => AssetSource.instance.sprites.items.blackCrystal;
        public override void ProjectileChange(Projectile projectile)
        {
            projectile.speed += 10;
        }
        public override void VelocityChange(ref Vector2 baseVelocity)
        {
            baseVelocity *= 0.5f;
        }
    }
}
