using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public Transform spawn_position;
    public CubeObject[]  cube_scriptable_objects; 
    public GameObject cube_object;




    void SpawnCube() 
    {
        CubeSpawn();
    }   
    
    void CubeSpawn() 
    {

        
        int _cube_object_number = Random.Range(0, cube_scriptable_objects.Length);
        Instantiate(cube_object,spawn_position.position,spawn_position.rotation);
        cube_object.TryGetComponent(out Cube _cube_object_new);

        _cube_object_new.cube_object = cube_scriptable_objects[_cube_object_number]; 
        _cube_object_new.destroy_event += SpawnCube;
    
    }
}
