using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonPlay : MonoBehaviour
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

    void OnMouseDown()
    {

    }
 
    void OnMouseUp()
    {
        TextMeshPro stat = GameObject.FindWithTag("Stats").GetComponent<TextMeshPro>();
        int max_record = PlayerPrefs.GetInt("maxrecord");
        stat.text = max_record.ToString();

        MainCamera.transform.localPosition = new Vector3(3.93f, 1.903f, -8.329f);
        Game.StepGame = 0;
        Setting.StartGame = true;
    }

    
}
