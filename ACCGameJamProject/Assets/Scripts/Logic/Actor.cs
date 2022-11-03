using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Actor
{
    public abstract int Speed{get;}
    public abstract int BaseMaxHP{get;}
    public int hp;
    public int maxHP;
    public Weapon weapon;
    public GameObject gameObject;
    public List<Item> items;
    public Actor(GameObject gameObject, Weapon weapon, List<Item> items){
        this.weapon = weapon;
        this.gameObject = gameObject;
        hp = BaseMaxHP;
        this.items = items;
    }
    public void TakeDamage(int damage){
        hp-=damage;
        if (hp<=0){
            Die();
        }
    }
<<<<<<< Updated upstream
    public virtual void Die(){
        GameObject.Destroy(gameObject);
    }
=======
    public void Heal(int healAmount){
        hp = System.Math.Min(maxHP, hp+healAmount);
    }
    public abstract void Die();
>>>>>>> Stashed changes
}
