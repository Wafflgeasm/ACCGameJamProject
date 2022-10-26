using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Actor
{
    public static GameObject EctoplasmPrefab => AssetSource.instance.gameObjects.ectoplasm;
    public Enemy(GameObject gameObject, Weapon weapon):base(gameObject, weapon){}
    public abstract int EctoplasmCount{get;}
    public abstract GameObject Prefab{get;}
    public abstract int AttackDistance{get;}
    public override void Die()
    {
        base.Die();
        GameObject.Instantiate(EctoplasmPrefab, gameObject.transform.position, Quaternion.identity).GetComponent<EctoplasmScript>().Init(EctoplasmCount);
        GameObject.Destroy(gameObject);
    }
}
