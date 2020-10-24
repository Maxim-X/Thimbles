using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBackToMainMenu : MonoBehaviour
{
    [SerializeField] private Camera MainCamera = null;
    [SerializeField] private SpriteRenderer settingsSprite = null;
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
        settingsSprite.gameObject.transform.localPosition = new Vector3(0.0984f, 3.89f, -6.9f);
    }
}
