using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    private SpriteRenderer button;
    [SerializeField] private Sprite spriteSoundOn = null;
    [SerializeField] private Sprite spriteSoundOff = null;

    // Включен ли звук в игре
    private bool isTheSoundTurnedOn = true;

    public AudioClip[] treks;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<SpriteRenderer>();
        // Запускаем трек
        if (isTheSoundTurnedOn == true)
        {
            GetComponent<AudioSource>().Play();
        }
        else
        {
            GetComponent<AudioSource>().Stop();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseUp()
    {
        if (isTheSoundTurnedOn)
        {
            // Выключаем звук в игре
            AudioListener.volume = 0;
            
            // Меняем картинку у кнопки на "button_soundOFF"
            button.sprite = spriteSoundOff;

            isTheSoundTurnedOn = false;
        }
        else
        {
            // Включаем звук в игре
            AudioListener.volume = 1;
            // Меняем картинку у кнопки на "button_soundON"
            button.sprite = spriteSoundOn;

            isTheSoundTurnedOn = true;
        }
        
    }
}
