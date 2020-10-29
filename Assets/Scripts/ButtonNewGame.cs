using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNewGame : MonoBehaviour
{
    // Диалоговое окно проигрыша
    [SerializeField] private SpriteRenderer gameOver_slideSprite = null;
    // Кнопка настроек
    [SerializeField] private SpriteRenderer settings_buttonSprite = null;
    // Слайд с количество очков
    [SerializeField] private SpriteRenderer pointsCount_Sprite = null;

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
        // Убираем диалоговое окно проигрыша
        gameOver_slideSprite.gameObject.transform.localPosition = new Vector3(-0.38f, 3.747f, -7.034f);
        // Показываем кнопку настроек
        settings_buttonSprite.gameObject.transform.localPosition = new Vector3(2.99874f, 2.43f, -3.76f);
        // Показываем слайд с количеством очков
        pointsCount_Sprite.gameObject.transform.localPosition = new Vector3(4.1f, 2.436f, -3.702f);

        // Начинаем игру заново
        Setting.EditRecord(0);
        Game.StepGame = 0;
        Setting.StartGame = true;
        Setting.pause = false;
    }
}
