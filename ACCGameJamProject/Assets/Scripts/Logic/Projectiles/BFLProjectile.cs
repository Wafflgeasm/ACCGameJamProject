using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BFLProjectile : Projectile
{
    public override float Speed => 20f;
    public override float Size => 10f;
    public override GameObject Prefab => AssetSource.instance.gameObjects.projectiles.BFL;
    public BFLProjectile(float damage):base(damage){}
    public override void OnDestroy()
    {
        Debug.Log("Yay");
    }
    public override void Update()
    {

    }

}
