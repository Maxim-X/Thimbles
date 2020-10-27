using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNewGame : MonoBehaviour
{
    // Диалоговое окно проигрыша
    [SerializeField] private SpriteRenderer gameOver_slideSprite = null;

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

        // Начинаем игру заново
        Setting.EditRecord(0);
        Game.StepGame = 1;
        Setting.StartGame = true;
        Setting.pause = false;
    }
}
