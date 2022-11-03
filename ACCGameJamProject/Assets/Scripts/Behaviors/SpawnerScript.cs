using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnerScript : MonoBehaviour
{
    private Vector2 size;
    private Vector2 origin;
    private Func<GameObject, Enemy> enemyGetter;
    private GameObject prefab;
    private float secondsBetweenSpawns;
    private float secondsSinceLastSpawn;
    private void Awake() {
        Init(enemyGetter: g=>new Ghost(g), secondsBetweenSpawns: 3); //JUST AN EXAMPLE. MUST BE CALLED FROM GAMEMANAGER IN THE NEW LEVEL FUNCTION
    }
    public void Init(Func<GameObject, Enemy> enemyGetter, float secondsBetweenSpawns, Vector2? origin = null, Vector2? size = null){
        this.secondsBetweenSpawns = secondsBetweenSpawns;
        this.enemyGetter = enemyGetter;
        prefab = enemyGetter(null).Prefab;
        origin??=transform.position;
        size??=transform.localScale;
        this.origin = origin.Value;
        this.size = size.Value;
        secondsSinceLastSpawn = 0;
    }
    private void Update() {
        secondsSinceLastSpawn+=Time.deltaTime;
        if (secondsSinceLastSpawn >= secondsBetweenSpawns){
            Vector2 spawnLocation;
            do{
                spawnLocation = origin+new Vector2(size.x*UnityEngine.Random.Range(0f,1), size.y*UnityEngine.Random.Range(0f,1));
            }while((spawnLocation - (Vector2)Player.instance.gameObject.transform.position).sqrMagnitude<10);
            Enemy newEnemy = enemyGetter(GameObject.Instantiate(prefab, spawnLocation, Quaternion.identity));
            newEnemy.gameObject.GetComponent<EnemyScript>().Init(newEnemy);
            secondsSinceLastSpawn = 0;
        }
    }
}
