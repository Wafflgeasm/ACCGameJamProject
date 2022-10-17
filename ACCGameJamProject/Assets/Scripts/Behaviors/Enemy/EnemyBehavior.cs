using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [Header("Enemy Properties:")]
    public int startingHealth;
    public float movementSpeed;
    public bool isMovementEnabled = true;
<<<<<<< Updated upstream
    private int currentHealth;
=======
    public int currentHealth;
    public const int ATTACKDISTANCE = 10;

    public Enemy enemy;

    [Header("Objects to Instantiate")]
    public GameObject ectoplasm;

    private bool isFiring;

    private float timeSinceLastShot;


>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======
        if ((playerRB.position - enemyRB.position).magnitude < ATTACKDISTANCE && timeSinceLastShot > enemy.Weapon.TimeBetweenShots)
        {
            Fire();
            timeSinceLastShot = 0;
        }
        timeSinceLastShot += Time.deltaTime;
>>>>>>> Stashed changes
    }


    void Movement()
    {
        UpdateMoveDir();
        enemyRB.velocity = moveDir * movementSpeed;
        enemyRB.transform.up = moveDir;
    }

<<<<<<< Updated upstream
=======
    void Fire()
    {
        GameObject projectileGameObject = GameObject.Instantiate(enemy.Weapon.Projectile.Prefab, transform.position, Quaternion.Euler(transform.up));
        projectileGameObject.GetComponent<ProjectileScript>().Init(transform.up, enemy.Weapon.Projectile, gameObject.tag);
    }

>>>>>>> Stashed changes
    void UpdateMoveDir()
    {
        if (playerRB != null)
        {
            moveDir = (playerRB.position - enemyRB.position).normalized;
            Debug.Log("X: " + moveDir.x + " Y: " + moveDir.y);
        }       
        //UpdateAnimator();
    }

<<<<<<< Updated upstream
=======
    public void TakeDamage(int _dmgAmount)
    {
        currentHealth -= _dmgAmount;
        if (currentHealth <= 0)
        {
            Instantiate(ectoplasm, transform.position, Quaternion.identity).GetComponent<PickupFloatingBehavior>().Init(enemy.EctoplasmCount);
            Destroy(gameObject);
        }
    }

>>>>>>> Stashed changes
    void UpdateAnimator()
    {
        GetComponent<Animator>().SetFloat("xSpeed", moveDir.x);
        GetComponent<Animator>().SetFloat("ySpeed", moveDir.y);
    }
}
