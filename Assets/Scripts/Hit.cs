using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    [SerializeField] private HitSound _hitSound;
    [SerializeField] private float _force;
    private Rigidbody _rb;
    private Animations _anim;
    private Collider _collider;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _anim = GetComponent<Animations>();
        _collider = GetComponent<Collider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hit"))
        {
            _rb.AddForce(Vector3.back * _force, ForceMode.Impulse);
            _anim.Death();
            _collider.enabled = false;
            _hitSound.OnSound();
        }
    }
}