using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;
    public Vector3 Cameravector;
    public Vector3 Newvector;
    [SerializeField] private float LerpValue;
    private void Start()
    {
        Cameravector = transform.position - Player.position;
    }
    private void LateUpdate()
    {
        cameraFollow();
    }
    private void cameraFollow()
    {
        Newvector = Vector3.Lerp(transform.position, Player.position + Cameravector, LerpValue * Time.deltaTime);
        transform.position = Newvector;
    }

}
