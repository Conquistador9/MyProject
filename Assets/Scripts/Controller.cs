using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jump;
    [SerializeField] private float _gravity;
    private CharacterController _controller;
    private Animations _animations;
    private Vector3 _playerVelocity;
    private bool _groundPlayer;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
        _animations = GetComponent<Animations>();
    }

    private void Update()
    {
        _groundPlayer = _controller.isGrounded;

        if (_groundPlayer && _playerVelocity.y < 0) _playerVelocity.y = 0;

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _controller.Move(move * Time.deltaTime * _speed);

        if (move != Vector3.zero) 
        {
            transform.forward = move;
            _animations.RunAnim();
        }
        else
        {
            _animations.RunAnim();
        }
  /*
        if (Input.GetButtonDown("Jump") && _groundPlayer)
        {
            _playerVelocity.y += Mathf.Sqrt(_jump * -2f * _gravity);
            _animations.JumpAnim();
        }
  */
        _playerVelocity.y += _gravity * Time.deltaTime;
        _controller.Move(_playerVelocity * Time.deltaTime);
    }
}