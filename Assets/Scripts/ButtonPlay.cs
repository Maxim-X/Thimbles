using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlay : MonoBehaviour
{
    [SerializeField]
    private Camera MainCamera = null;
    //private GameObject Button = GetComponent <Sprite>

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        MainCamera.transform.localPosition = new Vector3(0.1f, 1.903f, -8.329f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void AnimationClickButton()
    //{
    //    while()
    //}
}
