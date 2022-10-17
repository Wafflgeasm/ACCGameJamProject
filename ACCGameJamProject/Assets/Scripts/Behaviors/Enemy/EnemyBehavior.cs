using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [Header("Enemy Properties:")]
    public int startingHealth;
    public float movementSpeed;
    public bool isMovementEnabled = true;
    public int currentHealth;
    public const int ATTACKDISTANCE = 10;

    public Enemy enemy;

    [Header("Objects to Instantiate")]
    public GameObject ectoplasm;

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
        currentHealth = startingHealth;
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
        if ((playerRB.position - enemyRB.position).magnitude < ATTACKDISTANCE && timeSinceLastShot > enemy.Weapon.TimeBetweenShots)
        {
            Fire();
            timeSinceLastShot = 0;
        }
        timeSinceLastShot += Time.deltaTime;
    }


    void Movement()
    {
        UpdateMoveDir();
        enemyRB.velocity = moveDir * movementSpeed;
        enemyRB.transform.up = moveDir;
    }

    void Fire()
    {
        GameObject projectileGameObject = GameObject.Instantiate(enemy.Weapon.Projectile.Prefab, transform.position, Quaternion.Euler(transform.up));
        projectileGameObject.GetComponent<ProjectileScript>().Init(transform.up, enemy.Weapon.Projectile, gameObject.tag);
    }

    void UpdateMoveDir()
    {
        if (playerRB != null)
        {
            moveDir = (playerRB.position - enemyRB.position).normalized;
        }       
        //UpdateAnimator();
    }
    public void TakeDamage(int _dmgAmount)
    {
        currentHealth -= _dmgAmount;
        if (currentHealth <= 0)
        {
            Instantiate(ectoplasm, transform.position, Quaternion.identity).GetComponent<PickupFloatingBehavior>().Init(enemy.EctoplasmCount);
            Destroy(gameObject);
        }
    }

    void UpdateAnimator()
    {
        GetComponent<Animator>().SetFloat("xSpeed", moveDir.x);
        GetComponent<Animator>().SetFloat("ySpeed", moveDir.y);
    }
}
