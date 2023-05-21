using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject NewGameObject;
    [SerializeField] public GameObject GroundPrefab;
    public GameObject LastGameObject;
    public int Direction;
    void Start()
    {
        GenereateRandomGrounds();
        
    }

    
    public void GenereateRandomGrounds()
    {
        for (int i = 0;  i < 75; i++)
        {
            Spawner();
        }
    }
    public void Spawner()
    {
        Direction = Random.Range(0, 2);
        if (Direction == 0)
        {
            NewGameObject = Instantiate(GroundPrefab, new Vector3(LastGameObject.transform.position.x - 1f, LastGameObject.transform.position.y, LastGameObject.transform.position.z), Quaternion.identity);
            LastGameObject = NewGameObject;
        }
        else
        {
            NewGameObject = Instantiate(GroundPrefab, new Vector3(LastGameObject.transform.position.x, LastGameObject.transform.position.y, LastGameObject.transform.position.z + 1f), Quaternion.identity);
            LastGameObject = NewGameObject;
        }
    }
}
