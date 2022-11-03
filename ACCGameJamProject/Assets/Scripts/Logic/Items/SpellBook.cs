using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items{
    public class SpellBook : Item
    {
        public override Sprite Sprite => AssetSource.instance.sprites.items.spellBook;
        public override string Name => LanguageAsset.instance.items.names.spellBook;
        public override void ProjectileChange(Projectile projectile)
        {
            Player.instance.vacuumSuckDuration+=3;
        }
        public override void VelocityChange(ref Vector2 baseVelocity)
        {
            Player.instance.vacuumSuckSize+=1;
        }
    }
}
