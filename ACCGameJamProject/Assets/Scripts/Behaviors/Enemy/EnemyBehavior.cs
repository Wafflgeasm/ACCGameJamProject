using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [Header("Enemy Properties:")]
    public int startingHealth;
    public float movementSpeed;
    public bool isMovementEnabled = true;
    private int currentHealth;
    private Vector2 moveDir;

    private Rigidbody2D enemyRB;
    private Rigidbody2D playerRB;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        currentHealth = startingHealth;
        enemyRB = GetComponent<Rigidbody2D>();
        GameObject tempPlayer = GameObject.FindGameObjectWithTag("Player");
        if (tempPlayer)
        {
            playerRB = tempPlayer.GetComponent<Rigidbody2D>();
        }
        //InvokeRepeating("UpdateMoveDir", 0f, 1.5f);
    }

    void FixedUpdate()
    {
        Movement();
    }


    void Movement()
    {
        /* Vector2 screenBounds = Camera.main.ScreenToWorldPoint(new Vector3 (Screen.width, Screen.height, Camera.main.transform.position.z));        
        if (enemyRB.position.x < -screenBounds.x || enemyRB.position.x > screenBounds.x)
        {
            moveDir = new Vector2(-moveDir.x, moveDir.y);
            UpdateAnimator();            
        }
        if (enemyRB.position.y < -screenBounds.y || enemyRB.position.y > screenBounds.y)
        {
            moveDir = new Vector2(moveDir.x, -moveDir.y);
            UpdateAnimator();
        } */
        UpdateMoveDir();
        enemyRB.velocity = moveDir * movementSpeed;
    }

    void UpdateMoveDir()
    {
        if (playerRB != null)
        {
            moveDir = (playerRB.position - enemyRB.position).normalized;
            Debug.Log("X: " + moveDir.x + " Y: " + moveDir.y);
        }
        /* else
        {
            moveDir = new Vector2(Random.Range(-1, 1), Random.Range(-1, 1));
        } */        
        UpdateAnimator();
    }

    void UpdateAnimator()
    {
        GetComponent<Animator>().SetFloat("xSpeed", moveDir.x);
        GetComponent<Animator>().SetFloat("ySpeed", moveDir.y);
    }
}
