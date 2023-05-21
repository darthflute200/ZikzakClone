using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundfall : MonoBehaviour
{
    private Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public IEnumerator RbValues()
    {
        yield return new WaitForSeconds(0.75F);
        rb.useGravity = true;
        rb.isKinematic = false;
    }
}
