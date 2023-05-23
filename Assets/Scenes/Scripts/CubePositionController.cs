using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePositionController : MonoBehaviour
{
    public CubeSpawner cubespawner;
    private Rigidbody rb;
    [SerializeField] public float Yvalue;
    public int groundDirection;
    void Start()
    {
        cubespawner = FindObjectOfType<CubeSpawner>();
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        CheckYposition();
        
    }
    private void CheckYposition()
    {
        if(transform.position.y <= Yvalue)
        {
            SetRigidbody();
            groundDirection = Random.Range(0, 2);
            if (groundDirection == 0)
            {
                transform.position = new Vector3(cubespawner.LastGameObject.transform.position.x - 1f, cubespawner.LastGameObject.transform.position.y, cubespawner.LastGameObject.transform.position.z);

            }
            else
            {
                transform.position = new Vector3(cubespawner.LastGameObject.transform.position.x, cubespawner.LastGameObject.transform.position.y, cubespawner.LastGameObject.transform.position.z + 1f);

            }
            cubespawner.LastGameObject = gameObject;
        }
    }
    private void SetRigidbody()
    {
        rb.useGravity = false;
        rb.isKinematic = true;
    }
}
