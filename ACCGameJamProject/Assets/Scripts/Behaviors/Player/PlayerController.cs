using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int movementSpeed;
    public bool movementEnabled = true;

    private Transform flashLightPivot;
    private Rigidbody2D m_RB;

    private void Start()
    {
        m_RB = gameObject.GetComponent<Rigidbody2D>();
        flashLightPivot = transform.Find("Pivot Point");
    }

    private void FixedUpdate()
    {
        Movement();
        LookAtMouse();
    }

    public void Movement()
    {
        if (movementEnabled)
        {
            Vector2 directionalVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
            //Instant Accel/Decel using rb, we may want to add smoothing depending on feel but this is normally a good place to start.
            m_RB.velocity = directionalVector * movementSpeed;
        }
    }

    public void LookAtMouse()
    {
        Vector2 LookAtTarget = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 playerLocation = transform.position;

        Vector2 directionalVector = LookAtTarget - playerLocation;


        flashLightPivot.transform.up = directionalVector;
    }
}