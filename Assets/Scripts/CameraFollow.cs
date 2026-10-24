using System.Xml.Serialization;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform toFollow;
    [SerializeField] private Vector3 offset = new Vector3(0f, 2f, -10f);

    [SerializeField] private float smoothTime = 0.3f; // Time taken to reach the target

    private Vector3 _currentVelocity;

    void Start()
    {
        _currentVelocity = Vector3.zero; // set vector
    }

    private void LateUpdate()
    {
        if (toFollow == null) return;

        Vector3 targetPos = toFollow.position + offset;

        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref _currentVelocity, smoothTime);
    }
}
