using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Actor
{
    public abstract int startingHP{get;}
    public int hp;
    public GameObject gameObject;
    public Actor(GameObject gameObject){
        this.gameObject = gameObject;
        hp = startingHP;
    }
    public void TakeDamage(int damage){
        hp-=damage;
        if (hp<=0){
            Die();
        }
    }
    public virtual void Die(){
        GameObject.Destroy(gameObject);
    }
}
