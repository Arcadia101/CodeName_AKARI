using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
    private Rigidbody bulletRB;

    private void Awake() 
    {
        bulletRB = GetComponent<Rigidbody>();
    }

    private void Start() 
    {
        float speed = 10f;
        bulletRB.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.GetComponent<BulletTarget>() != null)
        {
            //Hit target.
            Debug.Log("Hit target");
        }
        else
        {
            //Hit something else.
            Debug.Log("Hit no target");
        }
        Destroy(gameObject);
    }
}
