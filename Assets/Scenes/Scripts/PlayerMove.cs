using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int count;
    [SerializeField] float speed;
    private Rigidbody rb;
    private Vector3 Direction;
    AudioSource audiosource;
    private void Move()
    {
        transform.position += speed * Direction * Time.deltaTime;
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
        audiosource = GetComponent<AudioSource>();
    }

    void Update()
    {
        Move();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Point"))
        {
            Destroy(other.gameObject);
            count++;
            audiosource.Play();
        }
    }

}
