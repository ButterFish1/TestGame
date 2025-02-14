using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private GroundCheker _groundCheker;
    [SerializeField] private CharacterController _controller;

    private float _moveSpeed;
    private float _jumpHeight;
    private float _gravity;

    private Vector3 _verticalVelocity = Vector3.zero;

    public void Initialize()
    {
        GetStatsFromConfig();
    }

    private void Awake()
    {
        Initialize();
    }

    private void Update()
    {
        Move(Input.GetAxis("Horizontal"));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        Fall();
    }

    public void Move(float direction)
    {
        if(direction != 0)
        {
            Vector3 moveDirection = transform.forward * direction;
            _controller.Move(moveDirection * _moveSpeed * Time.deltaTime);
        }

    }

    public void Jump()
    {
        if (_groundCheker.IsGrounded)
        {
            _verticalVelocity.y = Mathf.Sqrt(_jumpHeight * _gravity * -2f);
            _controller.Move(_verticalVelocity * Time.deltaTime);
        }
    }
    public void Fall()
    {
        if (_groundCheker.IsGrounded && _verticalVelocity.y <= 0f)
            _verticalVelocity.y = -2f;
        else
            _verticalVelocity.y += _gravity * Time.deltaTime;
        _controller.Move(_verticalVelocity * Time.deltaTime);
    }

    private void GetStatsFromConfig()
    {
        var config = Resources.Load<PlayerConfig>("PlayerConfig");
        _moveSpeed = config.MoveSpeed;
        _jumpHeight = config.JumpHeight;
        _gravity = config.Gravity;
    }
}
