using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls: MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private InputActionReference movementRef;

    private Rigidbody _rb;
    private Vector3 _movement;


    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _movement = movementRef.action.ReadValue<Vector3>();
    }

    void FixedUpdate()
    {
        MoveCharacter(_movement);
    }
    
    void MoveCharacter(Vector3 dir)
    {
        _rb.linearVelocity = dir * speed;
    }   

    public Vector3 GetMovement()
    {
        return _movement;
    }
};
