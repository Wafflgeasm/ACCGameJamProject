using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile
{
    public abstract int InitialDamage{get;}
    public abstract float InitialSpeed{get;}
    public abstract float InitialSize{get;}
    public virtual bool IsWallPiercingEnabled => false;
    public virtual int InitialPiercesLeft => 1;
    public int damage;
    public float speed;
    public float size;
    public int piercesLeft;
    public Projectile(){
        damage = InitialDamage;
        speed = InitialSpeed;
        size = InitialSize;
        piercesLeft = InitialPiercesLeft;
    }
    public abstract GameObject Prefab{get;}
    public virtual void Update(){}
    public virtual void OnDestroy(){}
}
