﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceCup : MonoBehaviour
{
    public static GameObject choiceCup = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (!Setting.pause)
        {
            choiceCup = gameObject;
            print(choiceCup);
        }
    }
}
