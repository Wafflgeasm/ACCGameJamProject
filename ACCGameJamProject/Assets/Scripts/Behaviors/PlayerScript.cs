using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Weapon weapon => Player.instance.weapon;
    [Header("Player Properties:")]
    public bool isMovementEnabled = true;
    private Transform flashLightPivot;
    private GameObject vacuum;
    private Rigidbody2D m_RigidBody;
    private float timeSinceLastShot;
    private void Awake()
    {
        Init();
    }

    private void FixedUpdate()
    {
        Movement();
    }
    private void Update() {
        LookAtMouse();
        timeSinceLastShot += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space)){
            weapon.isFiring = true;
        }
        if (Input.GetKey(KeyCode.Space) && timeSinceLastShot > weapon.TimeBetweenShots){
            Shoot();
            timeSinceLastShot = 0;
        }
        if (Input.GetKeyUp(KeyCode.Space)){
            weapon.isFiring = false;
        }
    }



    //internal functions
    private void Init()
    {
        m_RigidBody = GetComponent<Rigidbody2D>();
        flashLightPivot = transform.Find("Pivot Point");
        vacuum = transform.Find("Vacuum Hitbox").gameObject;
    }

    private void Movement()
    {
        if (isMovementEnabled)
        {
            Vector2 directionalVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
            //Instant Accel/Decel using rb, we may want to add smoothing depending on feel but this is normally a good place to start.
            m_RigidBody.velocity = directionalVector * Player.instance.Speed;
        }
    }

    private void LookAtMouse()
    {
        Vector2 LookAtTarget = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 playerLocation = transform.position;
        Vector2 directionalVector = LookAtTarget - playerLocation;
        flashLightPivot.transform.up = directionalVector;
    }
    private void Shoot(){
        GameObject projectileGameObject = GameObject.Instantiate(weapon.Projectile.Prefab, transform.position, Quaternion.Euler(flashLightPivot.transform.up));
        projectileGameObject.GetComponent<ProjectileScript>().Init(flashLightPivot.transform.up, weapon.Projectile, gameObject.tag);
    }
}