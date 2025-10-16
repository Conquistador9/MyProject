using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    [SerializeField] private float _force;
    private Rigidbody _rb;
    private Animations _anim;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _anim = GetComponent<Animations>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hit"))
        {
            _rb.AddForce(Vector3.back * _force, ForceMode.Impulse);
            _anim.Death();
        }
    }
}