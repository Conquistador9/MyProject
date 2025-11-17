using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebound : MonoBehaviour
{
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private Animations _animations;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _bounceForce;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _playerController.enabled = false;
            _rb.AddForce(Vector3.right * _bounceForce, ForceMode.Impulse);
            Debug.Log("gol");
            StartCoroutine(PlayerControllerOn());
        }
    }

    private IEnumerator PlayerControllerOn()
    {
        yield return new WaitForSeconds(1);
        _playerController.enabled = true;
    }
}