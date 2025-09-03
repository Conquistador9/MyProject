using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHit : MonoBehaviour
{
    [SerializeField] private float _force;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hit"))
        {
            Debug.Log("gol");
            Vector3 direction = (collision.transform.position - transform.position).normalized;
            collision.rigidbody.AddForce(direction * _force, ForceMode.Impulse);
        }
    }
}