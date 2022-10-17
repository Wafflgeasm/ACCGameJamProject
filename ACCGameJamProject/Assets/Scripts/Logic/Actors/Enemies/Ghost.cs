using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : Enemy
{
    public Ghost(GameObject gameObject):base(gameObject){}
    public override int startingHP => 60;
    public override int EctoplasmCount => 1;
    public override GameObject Prefab => AssetSource.instance.gameObjects.enemies.ghost;
    public override Weapon Weapon => new BFLWeapon();
}
