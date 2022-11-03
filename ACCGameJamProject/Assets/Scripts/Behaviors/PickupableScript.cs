using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupableScript : MonoBehaviour
{
    public static List<PickupableScript> all;
    private const float TIME_TO_REVERSE_DIRECTION = 0.75f;
    private bool isFloatingUp;
    private float timeFloating;
    private float floatSpeed = 0.85f;
    public Pickupable pickupable;
    public void Init(Pickupable pickupable){
        all.Add(this);
        this.pickupable = pickupable;
        StartCoroutine(ChangeDirection());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + Time.deltaTime * floatSpeed, transform.position.z);
    }

    IEnumerator ChangeDirection()
    {
        for (;;)
        {
            floatSpeed = -floatSpeed;
            yield return new WaitForSeconds(TIME_TO_REVERSE_DIRECTION);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag != "Player") return;
        all.Remove(this);
        pickupable.OnPickup();
        GameObject.Destroy(gameObject);
    }
}
