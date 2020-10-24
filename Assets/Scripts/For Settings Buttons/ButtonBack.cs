using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBack : MonoBehaviour
{
    [SerializeField] private Camera MainCamera = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUp()
    {
        MainCamera.transform.localPosition = new Vector3(-6.17f, 1.903f, -8.329f);
    }
}
