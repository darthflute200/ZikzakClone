using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDataTransmitter : MonoBehaviour
{
    [SerializeField] private Groundfall groundfall;
    public void SetGroundRigidbodyValues()
    {
        StartCoroutine(groundfall.RbValues());
    }
}
