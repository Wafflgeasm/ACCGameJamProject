using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items{
public class BallerinaBox : Item
{
    public override string Name => LanguageAsset.instance.items.names.ballerinaBox;
    public override Sprite Sprite => AssetSource.instance.sprites.items.ballerinaBox;
    public override void ProjectileChange(Projectile projectile)
    {
        projectile.speed -= 10;
    }
    public override void VelocityChange(ref Vector2 baseVelocity)
    {
        baseVelocity *= 2f;
    }
}
}
