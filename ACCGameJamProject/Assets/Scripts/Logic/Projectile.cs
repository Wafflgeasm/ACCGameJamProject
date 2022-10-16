using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile
{
    public Projectile(float damage){

    }
    public float damage;
    public abstract float Speed{get;}
    public abstract float Size{get;}
    public abstract GameObject Prefab{get;}
    public abstract void Update();
    public abstract void OnDestroy();
}
