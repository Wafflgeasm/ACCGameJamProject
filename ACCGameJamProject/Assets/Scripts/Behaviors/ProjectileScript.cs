using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    [SerializeField]
    private Vector2 direction;
    [SerializeField]
    private Projectile projectileType;
    [SerializeField]
    private Rigidbody2D m_RB;
    private float timeSinceCreated;
    //The tag of the object that fired the projectile. Used to prevent the projectile from destorying the object that fired it.
    private string entityFiring;
    public void Init(Vector2 initialDirection, Projectile projectileType, string entityFiring){
        direction = initialDirection;
        this.projectileType = projectileType;
        this.entityFiring = entityFiring;
        m_RB = GetComponent<Rigidbody2D>();
        timeSinceCreated = 0f;
    }
    private void Update() {
        timeSinceCreated += Time.deltaTime;
        if (timeSinceCreated > 10f){
            DestroyProjectile();
        }
    }
    public void FixedUpdate(){
        m_RB.velocity = projectileType.Speed * direction;
        projectileType.Update();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Wall"){
            DestroyProjectile();
        }
        if (other.gameObject.CompareTag("Enemy") && entityFiring != "Enemy")
        {
            EnemyBehavior eb = other.gameObject.GetComponent<EnemyBehavior>();
            if (eb != null)
            {
                eb.enemy.TakeDamage(projectileType.damage);
            }
            DestroyProjectile();
        }

        if (other.gameObject.CompareTag("Player") && entityFiring != "Player")
        {
            //Insert code here to damage player
            DestroyProjectile();
        }
        
    }


    private void DestroyProjectile(){
        projectileType.OnDestroy();
        GameObject.Destroy(gameObject);
    }
}
