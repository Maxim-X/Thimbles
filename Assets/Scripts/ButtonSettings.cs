using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Presets;

public class ButtonSettings : MonoBehaviour
{
    [SerializeField] private SpriteRenderer settingsSprite = null;

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
        
    }

    void OnMouseUp()
    {
        settingsSprite.gameObject.transform.localPosition = new Vector3(0.0984f, 1.666f, -7.658f);
    }


}
