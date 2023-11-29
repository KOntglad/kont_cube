using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeRay : MonoBehaviour
{

    float _click_time;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time >= _click_time) 
        {
            _click_time = Time.time + 0.5f;
            Ray _cube_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit _cube_ray_hit;
            Physics.Raycast(_cube_ray,out _cube_ray_hit, 50f);
            _cube_ray_hit.collider.gameObject.TryGetComponent(out Cube _cube_ray_object);
            _cube_ray_object.Click();
        }
    }
}
