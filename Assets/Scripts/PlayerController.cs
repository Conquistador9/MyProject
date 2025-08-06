using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    private Animations _animations;
    private Rigidbody _rb;

    private void Start()
    {
        _animations =GetComponent<Animations>();
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * _speed, _rb.velocity.y, 0);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            _animations.RunAnim();
        }
    }
}