using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundfallController : MonoBehaviour
{
    [SerializeField] GroundDataTransmitter groundDataTransmitter;
    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.CompareTag("Ball"))
        {
            groundDataTransmitter.SetGroundRigidbodyValues();
        }
    }
 
}
