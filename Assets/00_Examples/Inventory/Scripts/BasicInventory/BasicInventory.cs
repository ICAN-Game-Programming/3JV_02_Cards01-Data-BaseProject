using System;
using System.Collections.Generic;
using UnityEngine;

public class BasicInventory : MonoBehaviour
{
    #region Static Instance
    private static BasicInventory instance;
    public static BasicInventory Instance => instance;
    
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    #endregion
    
    
}

//todo item runtime object class