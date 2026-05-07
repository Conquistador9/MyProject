using System.Collections;
using UnityEngine;

public class ReboundRight : MonoBehaviour
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
            _rb.AddForce(Vector3.left * _bounceForce, ForceMode.Impulse);
            StartCoroutine(PlayerControllerOn());
        }
    }

    private IEnumerator PlayerControllerOn()
    {
        yield return new WaitForSeconds(1);

        if (_playerController)
            _playerController.enabled = true;
        else
            yield break;
    }
}