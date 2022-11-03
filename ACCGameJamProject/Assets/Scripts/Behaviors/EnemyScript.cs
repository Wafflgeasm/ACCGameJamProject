using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public static List<EnemyScript> all;
    [Header("Enemy Properties:")]
    public bool isMovementEnabled = true;
    public Enemy enemy;

    [Header("Objects to Instantiate")]
    private bool isFiring;
    private float timeSinceLastShot;
    private Vector2 moveDir;
    private Rigidbody2D enemyRigidBody;
    private Rigidbody2D playerRigidBody;

    public void Init(Enemy enemy)
    {
        all.Add(this);
        enemyRigidBody = GetComponent<Rigidbody2D>();
        timeSinceLastShot = 0;
        playerRigidBody = Player.instance.gameObject.GetComponent<Rigidbody2D>();
        this.enemy = enemy;
        //InvokeRepeating("UpdateMoveDir", 0f, 1.5f);
    }


    void FixedUpdate()
    {
        Movement();
        if ((playerRigidBody.position - enemyRigidBody.position).magnitude < enemy.AttackDistance && timeSinceLastShot > enemy.weapon.TimeBetweenShots)
        {
            Fire();
            timeSinceLastShot = 0;
        }
        
        timeSinceLastShot += Time.deltaTime;
    }


    void Movement()
    {
        UpdateMoveDir();
        Vector2 velocity = moveDir * enemy.Speed;
        enemyRigidBody.velocity = velocity;
        enemyRigidBody.transform.up = moveDir;
    }

    void Fire()
    {
        GameObject projectileGameObject = GameObject.Instantiate(enemy.weapon.Projectile.Prefab, transform.position, Quaternion.Euler(transform.up));
        projectileGameObject.GetComponent<ProjectileScript>().Init(transform.up, enemy.weapon.Projectile, gameObject.tag);
    }

    void UpdateMoveDir()
    {
        if (playerRigidBody != null)
        {
            moveDir = (playerRigidBody.position - enemyRigidBody.position).normalized;
        }       
        //UpdateAnimator();
    }
<<<<<<< Updated upstream
    public void TakeDamage(int damage)
    {
        enemy.hp -= damage;
        if (enemy.hp <= 0)
        {
            enemy.Die();
        }
    }
=======
>>>>>>> Stashed changes

    void UpdateAnimator()
    {
        GetComponent<Animator>().SetFloat("xSpeed", moveDir.x);
        GetComponent<Animator>().SetFloat("ySpeed", moveDir.y);
    }
}
