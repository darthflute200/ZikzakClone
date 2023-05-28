using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePositionController : MonoBehaviour
{
    public GameObject Point;
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
            groundDirection = Random.Range(0, 4);
            if (groundDirection == 0)
            {
                transform.position = new Vector3(cubespawner.LastGameObject.transform.position.x - 1f, cubespawner.LastGameObject.transform.position.y, cubespawner.LastGameObject.transform.position.z);

            }
            if (groundDirection == 1)
            {
                transform.position = new Vector3(cubespawner.LastGameObject.transform.position.x, cubespawner.LastGameObject.transform.position.y, cubespawner.LastGameObject.transform.position.z + 1f);

            }
            if(groundDirection == 2)
            {
                transform.position = new Vector3(cubespawner.LastGameObject.transform.position.x - 1f, cubespawner.LastGameObject.transform.position.y, cubespawner.LastGameObject.transform.position.z);
                Instantiate(Point, new Vector3(cubespawner.LastGameObject.transform.position.x, cubespawner.LastGameObject.transform.position.y + 1f, cubespawner.LastGameObject.transform.position.z), Quaternion.identity);
            }
            if (groundDirection == 3)
            {
                transform.position = new Vector3(cubespawner.LastGameObject.transform.position.x, cubespawner.LastGameObject.transform.position.y, cubespawner.LastGameObject.transform.position.z + 1f);
                Instantiate(Point, new Vector3(cubespawner.LastGameObject.transform.position.x, cubespawner.LastGameObject.transform.position.y + 1f, cubespawner.LastGameObject.transform.position.z), Quaternion.identity);
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
