using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityActive : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Road"))
        {
            other.GetComponent<Rigidbody>().useGravity = true;
            other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }
}