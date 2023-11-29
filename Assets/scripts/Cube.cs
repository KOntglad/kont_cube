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

    public int cube_destroy_click_amount;
    

    private void awake()
    {
        gameObject.TryGetComponent(out Material cube_material);
        cube_destroy_click_amount = cube_object_controller.CubeScriptableObject.click_amount;
        cube_material.color = cube_object_controller.CubeScriptableObject.cube_color;
    }
    

    



    public void Click() 
   {
        cube_object_controller.CubeScriptableObject.click_amount--;
        Debug.Log(cube_object_controller.CubeScriptableObject.click_amount + " defa basilirsa yok olacak");
        gameObject.transform.DOShakePosition(0.2f, 0.3f, 3, 90f,false,true,ShakeRandomnessMode.Full);

        if(cube_object_controller.CubeScriptableObject.click_amount < 0) 
        {
            Debug.Log("kup yok ediliyor");
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
