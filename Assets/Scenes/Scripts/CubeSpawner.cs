using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject Point;
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
        Direction = Random.Range(0, 4);
        if (Direction == 0)
        {
            NewGameObject = Instantiate(GroundPrefab, new Vector3(LastGameObject.transform.position.x - 1f, LastGameObject.transform.position.y, LastGameObject.transform.position.z), Quaternion.identity);
            LastGameObject = NewGameObject;
        }
        if (Direction == 1)
        {
            NewGameObject = Instantiate(GroundPrefab, new Vector3(LastGameObject.transform.position.x, LastGameObject.transform.position.y, LastGameObject.transform.position.z + 1f), Quaternion.identity);
            LastGameObject = NewGameObject;
        }
        if (Direction == 2)
        {
            NewGameObject = Instantiate(GroundPrefab, new Vector3(LastGameObject.transform.position.x - 1f, LastGameObject.transform.position.y, LastGameObject.transform.position.z), Quaternion.identity);
            LastGameObject = NewGameObject;
            Instantiate(Point, new Vector3(LastGameObject.transform.position.x, LastGameObject.transform.position.y + 1f, LastGameObject.transform.position.z), Quaternion.identity);

        }
        if (Direction == 3)
        {
            NewGameObject = Instantiate(GroundPrefab, new Vector3(LastGameObject.transform.position.x, LastGameObject.transform.position.y, LastGameObject.transform.position.z + 1f), Quaternion.identity);
            LastGameObject = NewGameObject;
            Instantiate(Point, new Vector3(LastGameObject.transform.position.x, LastGameObject.transform.position.y + 1f, LastGameObject.transform.position.z), Quaternion.identity);
        }
    }
}
