using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlay : MonoBehaviour
{

    [SerializeField] private Camera MainCamera = null;
    //private GameObject button = 
    private SpriteRenderer Button;

    private SpriteRenderer AnimationButton = null;
    private Vector3 newScaleButton = new Vector3(1f, 1f, 1f);

    // Start is called before the first frame update
    void Start()
    {
        Button = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, newScaleButton, Time.deltaTime + 0.1f);
    }

    void OnMouseDown()
    {
        newScaleButton = new Vector3(0.9f, 0.9f, 1f);
    }
 
    void OnMouseUp()
    {
        newScaleButton = new Vector3(1f, 1f, 1f);
        MainCamera.transform.localPosition = new Vector3(0.1f, 1.903f, -8.329f);
    }

    
}
