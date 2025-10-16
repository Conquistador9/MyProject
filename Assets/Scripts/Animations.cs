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

    public void RunAnim() => _animator.SetBool("Moved", true);

    public void Idle() => _animator.SetBool("Moved", false);

    public void Death() => _animator.SetTrigger("Death");
}