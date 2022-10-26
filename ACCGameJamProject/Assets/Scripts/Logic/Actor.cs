using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Actor
{
    public abstract int StartingHP{get;}
    public int hp;
    public int maxHP{get;}
    public abstract int Speed{get;}
    public Weapon weapon;
    public GameObject gameObject;
    public Actor(GameObject gameObject, Weapon weapon){
        this.weapon = weapon;
        this.gameObject = gameObject;
        hp = StartingHP;
    }
    public void TakeDamage(int damage){
        hp-=damage;
        if (hp<=0){
            Die();
        }
    }
    public void Heal(int healAmount){
        hp = System.Math.Min(maxHP, hp+healAmount);
    }
    public virtual void Die(){
        GameObject.Destroy(gameObject);
    }
}
