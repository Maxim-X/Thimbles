using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressAnimation : MonoBehaviour
{
    private SpriteRenderer button;
    private Vector3 newScaleButton = new Vector3(1f, 1f, 1f);
    private bool animationEditScale = false;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animationEditScale)
        {
            button.transform.localScale = Vector3.Lerp(transform.localScale, newScaleButton, Time.deltaTime + 0.1f);
            if (Math.Round(button.transform.localScale.x, 2) == 0.99)
            {
                Game.StartGame = true;
                animationEditScale = false;
            }
        }

    }

    void OnMouseDown()
    {
        animationEditScale = true;
        newScaleButton = new Vector3(0.8f, 0.8f, 1f);
    }

    void OnMouseUp()
    {
        newScaleButton = new Vector3(1f, 1f, 1f);
    }
}
