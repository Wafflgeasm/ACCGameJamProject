using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class GameManager
{
    public static bool isPaused;
    public static int treasureKeys;
    public static List<Enemy> enemies;
    public static void Pause(){
        isPaused = true;
    }
    public static void Unpause(){
        isPaused = false;
    }
    public static void NewGame(){
        EnemyScript.all = new List<EnemyScript>();
        ProjectileScript.all = new List<ProjectileScript>();
        PickupableScript.all = new List<PickupableScript>();
        treasureKeys = 0;
        isPaused = false;
        Player.instance = new Player(GameObject.Instantiate(AssetSource.instance.gameObjects.player),Weapon.playerWeapon, new List<Item>{});
        NewLevel();
        //Locking the door
    }
    public static void NewLevel(){
        //Spawner initiation
    }
    public static void Lose(){
        Debug.Log("Lost");
        GameObject.Destroy(Player.instance.gameObject);
        EnemyScript.all.ForEach(s=>GameObject.Destroy(s.gameObject));
        PickupableScript.all.ForEach(s=>GameObject.Destroy(s.gameObject));
        ProjectileScript.all.ForEach(s=>GameObject.Destroy(s.gameObject));
        EnemyScript.all.Clear();
        PickupableScript.all.Clear();
        ProjectileScript.all.Clear();
        NewGame();
    }
    public static void Exit(){

    }
}
