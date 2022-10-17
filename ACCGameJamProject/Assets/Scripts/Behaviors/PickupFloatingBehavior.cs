using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupFloatingBehavior : MonoBehaviour
{
    private bool isFloatingUp;
    private float timeFloating;
    public float floatSpeed;
    private const float TIME_TO_REVERSE_DIRECTION = 0.75f;
    public int ectoplasmCount;
    public void Init(int ectoplasmCount){
        this.ectoplasmCount = ectoplasmCount;
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
        GameObject.Destroy(gameObject);
        GameManager.GainEctoplasm(ectoplasmCount);
    }
}
