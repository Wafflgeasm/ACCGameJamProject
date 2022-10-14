using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Properties:")]
    public int startingHealth;
    public int movementSpeed;
    public bool isMovementEnabled = true;
    private int currentHealth;


    [Header("Weapon Properties:")]
    public float rateOfFire;
    public float damageOnHit;
    public float projectileSpeed;
    public float projectileSize;
    private bool isFiring;

    [Header("Vacuum Properties:")]
    public float suckSize;
    public float suckDuration;
    private bool isSucking;


    private Transform flashLightPivot;
    private GameObject vacuum;
    private Rigidbody2D m_RB;

    private void Awake()
    {
        Init();
    }

    private void FixedUpdate()
    {
        Movement();
        LookAtMouse();
    }

    //This probably needs to be moved to the game manager, leaving it here for now.
    public static void TakeDamage(int damageDealt, int healthPoolToApplyDamageTo)
    {
        healthPoolToApplyDamageTo -= damageDealt;
    }



    //internal functions
    private void Init()
    {
        currentHealth = startingHealth;
        m_RB = gameObject.GetComponent<Rigidbody2D>();
        flashLightPivot = transform.Find("Pivot Point");
        vacuum = transform.Find("Vacuum Hitbox").gameObject;
    }

    private void Movement()
    {
        if (isMovementEnabled)
        {
            Vector2 directionalVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
            //Instant Accel/Decel using rb, we may want to add smoothing depending on feel but this is normally a good place to start.
            m_RB.velocity = directionalVector * movementSpeed;
        }
    }

    private void LookAtMouse()
    {
        Vector2 LookAtTarget = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 playerLocation = transform.position;

        Vector2 directionalVector = LookAtTarget - playerLocation;


        flashLightPivot.transform.up = directionalVector;
    }
}