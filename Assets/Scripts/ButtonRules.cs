using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRules : MonoBehaviour
{
    [SerializeField] private SpriteRenderer settingsSprite = null;
    [SerializeField] private SpriteRenderer rulesSprite = null;
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
        // Убираем со сцены слайд с настройками
        settingsSprite.gameObject.transform.localPosition = new Vector3(0.0984f, 3.89f, -6.9f);

        // Перемещаем на сцену слайд с правилами
        rulesSprite.gameObject.transform.localPosition = new Vector3(3.93f, 1.666f, -7.658f);
    }
}
