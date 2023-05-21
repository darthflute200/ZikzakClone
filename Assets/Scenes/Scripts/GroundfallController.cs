using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundfallController : MonoBehaviour
{
    [SerializeField] GroundDataTransmitter groundDataTransmitter;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            groundDataTransmitter.SetGroundRigidbodyValues();
        }
    }
 
}
