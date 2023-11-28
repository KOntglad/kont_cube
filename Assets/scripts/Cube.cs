using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Cube : MonoBehaviour
{
    int _clickAmountToDestroy;
    public Action destroy_event;
    public CubeController cube_object_controller;


    private void awake()
    {
        gameObject.TryGetComponent(out MeshRenderer cube_render);
        cube_render.material.color = cube_object_controller.CubeScriptableObject.cube_color;
    }


    



    public void Click() 
   {
        cube_object_controller.CubeScriptableObject.click_amount--;
        if(cube_object_controller.CubeScriptableObject.click_amount < 0) 
        {
            Destroy();   
        }
   }

   void Destroy()
   {
        gameObject.transform.DOScale(0, 1).OnComplete(() => 
        {
            destroy_event?.Invoke();
            Destroy(gameObject);
        });
        
       
    
   }

}
