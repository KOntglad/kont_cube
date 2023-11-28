using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public Transform spawn_position;
    public GameObject[] cube_objects;



    void SpawnCube() 
    {
        CubeSpawn();
        
    }   
    
    void CubeSpawn() 
    {
                
        Instantiate(cube_objects[Random.Range(0,cube_objects.Length)],spawn_position.position,spawn_position.rotation);
        
    }
}
