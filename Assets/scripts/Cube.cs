using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Cube : MonoBehaviour
{
    int _clickAmountToDestroy;
    public static Action destroy_event;
    public CubeObject cube_object;

    public int cube_destroy_click_amount;

    private void Start()
    {
        cube_destroy_click_amount = cube_object.click_amount;
        gameObject.TryGetComponent(out MeshRenderer cube_material);
        cube_material.materials[0].color = cube_object.cube_color;
    }



    private void OnEnabled()
    {
        cube_destroy_click_amount = cube_object.click_amount;
        gameObject.TryGetComponent(out MeshRenderer cube_material);
        cube_material.materials[0].color = cube_object.cube_color;
    }
    

    



    public void Click() 
   {
        cube_destroy_click_amount--;
        Debug.Log(cube_destroy_click_amount + " defa basilirsa yok olacak");
        gameObject.transform.DOShakePosition(0.2f, 0.3f, 3, 90f,false,true,ShakeRandomnessMode.Full);

        if(cube_destroy_click_amount < 0) 
        {
            Debug.Log("kup yok ediliyor");
            DestroyCube();
        }
   }

   void DestroyCube()
   {
       
        gameObject.transform.DOScale(0, 1).OnComplete(() => 
        {
            destroy_event?.Invoke(); 
            Destroy(gameObject);
        });
        
       
    
   }

}
