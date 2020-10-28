using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButtonNormalize : MonoBehaviour
{
    private SpriteRenderer button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseUp()
    {
        button.transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
