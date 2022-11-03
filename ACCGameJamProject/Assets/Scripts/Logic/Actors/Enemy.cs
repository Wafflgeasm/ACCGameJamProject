using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Actor
{
    public static GameObject EctoplasmPrefab => AssetSource.instance.gameObjects.ectoplasm;
    public Enemy(GameObject gameObject, Weapon weapon, List<Item> items):base(gameObject, weapon, items){}
    public abstract int EctoplasmCount{get;}
    public abstract GameObject Prefab{get;}
    public abstract int AttackDistance{get;}
    public override void Die()
    {
<<<<<<< Updated upstream
        base.Die();
        GameObject.Instantiate(EctoplasmPrefab, gameObject.transform.position, Quaternion.identity);
=======
        GameObject.Instantiate(EctoplasmPrefab, gameObject.transform.position, Quaternion.identity).GetComponent<PickupableScript>().Init(new Pickupables.Ectoplasm(EctoplasmCount));
        GameObject.Destroy(gameObject);
        EnemyScript.all.Remove(gameObject.GetComponent<EnemyScript>());
>>>>>>> Stashed changes
    }
}
