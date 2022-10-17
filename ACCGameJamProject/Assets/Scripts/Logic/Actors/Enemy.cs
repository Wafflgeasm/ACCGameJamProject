using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Actor
{
    public Enemy(GameObject gameObject):base(gameObject){}
    public static GameObject EctoplasmPrefab => AssetSource.instance.gameObjects.ectoplasm;
    public abstract int EctoplasmCount{get;}
    public abstract Weapon Weapon{get;}
    public abstract GameObject Prefab{get;}
    public override void Die()
    {
        base.Die();
        GameObject.Instantiate(EctoplasmPrefab, gameObject.transform.position, Quaternion.identity);
    }
}
