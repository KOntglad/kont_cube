using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Cube : MonoBehaviour
{
    int _clickAmountToDestroy;
    
    public Action destroy_event;

    private void OnEnable()
    {
        //destroy_event +=  
    }

    private void OnDestroy()
    {
        
    }

    public void Click() 
   {
        _clickAmountToDestroy--;
        if(_clickAmountToDestroy < 0) 
        {
            Destroy();   
        }
   }

   void Destroy()
   {

   
   }

}
