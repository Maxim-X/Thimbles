using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonVibration : MonoBehaviour
{
    private SpriteRenderer button;
    [SerializeField] private Sprite spriteVibrationOn = null;
    [SerializeField] private Sprite spriteVibrationOff = null;

    // Включена ли вибрация в игре
    private bool isTheVibrationTurnedOn = true;

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
        if (isTheVibrationTurnedOn)
        {
            // Выключаем вибрации в игре
            Setting.Vibrate = false;

            // Меняем картинку у кнопки на "button_vibrateOFF"
            button.sprite = spriteVibrationOff;

            isTheVibrationTurnedOn = false;
        }
        else
        {
            // Включаем вибрации в игре
            Setting.Vibrate = true;

            // Меняем картинку у кнопки на "button_vibrateON"
            button.sprite = spriteVibrationOn;

            isTheVibrationTurnedOn = true;
        }

    }
}
