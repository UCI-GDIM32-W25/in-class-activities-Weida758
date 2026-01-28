using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour
{
    public static Locator Instance { get; private set; }
    public W4Pigeon player { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this){
            Destroy(this);
            return;

        }

        Instance = this;
        
        player = GameObject.FindWithTag("Player").GetComponent<W4Pigeon>();
        DontDestroyOnLoad(this);
    }
    
    
    
}
