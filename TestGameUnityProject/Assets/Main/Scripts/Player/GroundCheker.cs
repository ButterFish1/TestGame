using UnityEngine;

public class GroundCheker : MonoBehaviour
{
    [SerializeField] private float _checkRadius;
    [SerializeField] private LayerMask _layerMask;
    
    public bool IsGrounded { get => Physics.CheckSphere(transform.position, _checkRadius,_layerMask); }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, _checkRadius);
    }
}