using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [Header("Enemy Properties:")]
    public bool isMovementEnabled = true;
    public Enemy enemy;

    [Header("Objects to Instantiate")]
    private bool isFiring;
    private float timeSinceLastShot;
    private Vector2 moveDir;
    private Rigidbody2D enemyRB;
    private Rigidbody2D playerRB;

    private void Awake() {
        enemy = new Ghost(gameObject);
        Init(enemy);
    }

    private void Init(Enemy enemy)
    {
        enemyRB = GetComponent<Rigidbody2D>();
        timeSinceLastShot = 0;
        GameObject tempPlayer = GameObject.FindGameObjectWithTag("Player");
        if (tempPlayer)
        {
            playerRB = tempPlayer.GetComponent<Rigidbody2D>();
        }
        this.enemy = enemy;
        //InvokeRepeating("UpdateMoveDir", 0f, 1.5f);
    }

    void FixedUpdate()
    {
        Movement();
        if ((playerRB.position - enemyRB.position).magnitude < enemy.AttackDistance && timeSinceLastShot > enemy.weapon.TimeBetweenShots)
        {
            Fire();
            timeSinceLastShot = 0;
        }
        timeSinceLastShot += Time.deltaTime;
    }


    void Movement()
    {
        UpdateMoveDir();
        enemyRB.velocity = moveDir * enemy.Speed;
        enemyRB.transform.up = moveDir;
    }

    void Fire()
    {
        GameObject projectileGameObject = GameObject.Instantiate(enemy.weapon.Projectile.Prefab, transform.position, Quaternion.Euler(transform.up));
        projectileGameObject.GetComponent<ProjectileScript>().Init(transform.up, enemy.weapon.Projectile, gameObject.tag);
    }

    void UpdateMoveDir()
    {
        if (playerRB != null)
        {
            moveDir = (playerRB.position - enemyRB.position).normalized;
        }       
        //UpdateAnimator();
    }
    public void TakeDamage(int damage)
    {
        enemy.hp -= damage;
        if (enemy.hp <= 0)
        {
            enemy.Die();
        }
    }

    void UpdateAnimator()
    {
        GetComponent<Animator>().SetFloat("xSpeed", moveDir.x);
        GetComponent<Animator>().SetFloat("ySpeed", moveDir.y);
    }
}
