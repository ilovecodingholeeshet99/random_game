using UnityEngine;

public class PlayerControls: MonoBehaviour
{
    [SerializeField] private int speed;
    private Rigidbody _rb;
    private Vector3 _movement;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _movement = new Vector3(Input.GetAxis("Horizontal"), 0 ,Input.GetAxis("Vertical")).normalized;
    }

    void FixedUpdate()
    {
        MoveCharacter(_movement);
    }
    
    void MoveCharacter(Vector3 dir)
    {
        _rb.linearVelocity = dir * speed;
    }
};
