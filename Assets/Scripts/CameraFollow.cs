using System.Xml.Serialization;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform toFollow;
    [SerializeField] private Vector3 offset = new Vector3(0f, 2f, -10f);

    private Vector3 _movementRef;
    void Start()
    {
        _movementRef = toFollow.GetComponent<PlayerControls>().GetMovement();
    }
    private void LateUpdate()
    {
        if (toFollow == null) return;

        Vector3 targetPos = toFollow.position + offset;

        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref _movementRef, 0);
    }
}
