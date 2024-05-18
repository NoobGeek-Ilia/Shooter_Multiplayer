using UnityEngine;

public class BaseTargetFollow : MonoBehaviour
{
    protected Vector3 _currVelocity;
    protected virtual float _smoothTime { get; set; } = 0.1f;

    public virtual void MoveTo(Transform target)
    {
        Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _currVelocity, _smoothTime);
    }
}
