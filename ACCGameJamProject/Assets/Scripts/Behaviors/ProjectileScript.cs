using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public static List<ProjectileScript> all;
    private Vector2 direction;
<<<<<<< Updated upstream
    [SerializeField]
    private Projectile projectileType;
=======
    private Projectile projectile;
>>>>>>> Stashed changes
    [SerializeField]
    private Rigidbody2D rigidBody;
    private float timeSinceShot;
    //The tag of the object that fired the projectile. Used to prevent the projectile from destorying the object that fired it.
    private string entityFiring;
    public void Init(Vector2 initialDirection, Projectile projectileType, string entityFiring){
        all.Add(this);
        direction = initialDirection;
        this.projectileType = projectileType;
        this.entityFiring = entityFiring;
        timeSinceShot = 0f;
        transform.localScale = Vector3.one*projectile.size;
    }
    private void Update() {
        timeSinceShot += Time.deltaTime;
        if (timeSinceShot > 10f)
            DestroyProjectile();
    }
    public void FixedUpdate(){
<<<<<<< Updated upstream
        m_RB.velocity = projectileType.Speed * direction;
        projectileType.Update();
=======
        rigidBody.velocity = projectile.speed * direction;
        projectile.Update();
>>>>>>> Stashed changes
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Wall" && !projectile.IsWallPiercingEnabled)
            DestroyProjectile();
        Actor reciever = null;
        if (other.gameObject.CompareTag("Enemy") && entityFiring != "Enemy")
<<<<<<< Updated upstream
        {
            EnemyScript eb = other.gameObject.GetComponent<EnemyScript>();
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
        
=======
            reciever = other.gameObject.GetComponent<EnemyScript>().enemy;
        if (other.gameObject.CompareTag("Player") && entityFiring != "Player")
            reciever = Player.instance;
        if (reciever == null)
            return;
        reciever.TakeDamage(projectile.damage);
        projectile.piercesLeft--;
        if (projectile.piercesLeft == 0)
            DestroyProjectile();
>>>>>>> Stashed changes
    }


    private void DestroyProjectile(){
<<<<<<< Updated upstream
        projectileType.OnDestroy();
=======
        all.Remove(this);
        projectile.OnDestroy();
>>>>>>> Stashed changes
        GameObject.Destroy(gameObject);
    }
}
