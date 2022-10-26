using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : Enemy
{
    public Ghost(GameObject gameObject):base(gameObject, new BFLWeapon()){}
    public override int StartingHP => 60;
    public override int EctoplasmCount => 1;
    public override GameObject Prefab => AssetSource.instance.gameObjects.enemies.ghost;
    public override int AttackDistance => 10;
    public override int Speed => 2;
}
