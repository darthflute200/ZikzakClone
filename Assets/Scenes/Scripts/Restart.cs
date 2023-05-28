using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Transform Player;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            SceneManager.LoadScene(0);
        }
    }
    private void LateUpdate()
    {
        Vector3 Way = new Vector3(Player.position.x, transform.position.y, Player.position.z);
        transform.position = Way;
    }
}
