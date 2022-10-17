using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Actor
{
    public Player(GameObject gameObject):base(gameObject){}
    public override int startingHP => 100;
    public int maxHP;
    public void Heal(){

    }
}
