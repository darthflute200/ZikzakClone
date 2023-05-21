using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float speed;
    private Rigidbody rb;
    private Vector3 Direction;
    private void Move()
    {
        rb.velocity = speed * Direction;
        if (Input.GetMouseButton(0))
        {
            Direction = Vector3.left;
        }
        else
        {
            Direction = Vector3.forward;
        }
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Direction = Vector3.forward;
    }

    void Update()
    {
        Move();
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            Direction = Vector3.zero;
        }
    }
}
