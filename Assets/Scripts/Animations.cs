using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void JumpAnim() => _animator.SetBool("Jump", true);

    public void RunAnim() => _animator.SetBool("Jump", false);
}