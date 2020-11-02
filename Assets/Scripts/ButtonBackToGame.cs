using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBackToGame : MonoBehaviour
{
    [SerializeField] private SpriteRenderer settingsSprite = null;
    // Кнопка настроек
    [SerializeField] private SpriteRenderer settings_buttonSprite = null;

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
        Setting.pause = false;
        // Прячем слайд настроек
        settingsSprite.gameObject.transform.localPosition = new Vector3(0.0984f, 3.89f, -6.9f);
        // Показываем кнопку настроек
        settings_buttonSprite.gameObject.transform.localPosition = new Vector3(3.147f, 2.43f, -3.76f);
    }
}