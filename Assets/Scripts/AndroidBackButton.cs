using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidBackButton : MonoBehaviour
{

    // Спрайт слайда настроек
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
        // Если запущено на андроиде
        if (Application.platform == RuntimePlatform.Android)
        {
            // Если нажата аппаратная кнопка назад на телефоне, то открываем настройки и ставим игру на паузу
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Setting.pause = true;
                // Показываем слайд настроек
                settingsSprite.gameObject.transform.localPosition = new Vector3(3.93f, 1.666f, -7.658f);
                // Прячем кнопку настроек
                settings_buttonSprite.gameObject.transform.localPosition = new Vector3(0f, 0f, 0f);
            }
        }
    }
}
