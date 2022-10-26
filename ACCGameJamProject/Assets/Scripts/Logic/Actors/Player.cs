using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Actor
{
    public static Player instance;
    public static void Init(){

    }
    public override int StartingHP => 100;
    public override int Speed => 5;
    public float vacuumSuckSize;
    public float vacuumSuckDuration;
    public bool isVacuumSucking;
    public Player(GameObject gameObject, Weapon weapon):base(gameObject, weapon){}
    public void Heal(){

    }
}
