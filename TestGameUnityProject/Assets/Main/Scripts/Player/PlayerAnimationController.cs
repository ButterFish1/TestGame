using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private GroundCheker _groundCheker;



    private void Update()
    {
        _animator.SetBool("Grounded", _groundCheker.IsGrounded);
        _animator.SetBool("Jump", Input.GetKeyDown(KeyCode.Space));
        _animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));
        _animator.SetFloat("MotionSpeed", Input.GetAxis("Horizontal") * 2);

    }
}

