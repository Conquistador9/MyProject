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

    private void Update()
    {
        MoveCharacter();
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * _speed, _rb.velocity.y, 0);
    }

    private void MoveCharacter()
    {
        if(_rb.velocity.x > 0)
            _animations.RunAnim();

        else if(_rb.velocity.x < 0)
            _animations.RunAnim();

        else if (_rb.velocity.x == 0)
            _animations.Idle();
    }
}