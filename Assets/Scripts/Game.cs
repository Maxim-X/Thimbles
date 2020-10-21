using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private GameObject Cup_1 = null;
    [SerializeField] private GameObject Cup_2 = null;
    [SerializeField] private GameObject Cup_3 = null;
    private GameObject correct_cup;
    private GameObject choiceCup;
    GameObject[] AllCup = null;
    private SpriteRenderer button;
    private Vector3 newScaleButton = new Vector3(1f, 1f, 1f);
    private bool animationEditScale = false;
    private bool StartGame = false;
    private int StepGame = 1;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<SpriteRenderer>();
        AllCup = new GameObject[] { Cup_1,Cup_2,Cup_3 };
    }

    // Update is called once per frame
    void Update()
    {

       

        if (animationEditScale)
        {
            button.transform.localScale = Vector3.Lerp(transform.localScale, newScaleButton, Time.deltaTime + 0.1f);
            if (Math.Round(button.transform.localScale.x, 2) == 0.99)
            {
                animationEditScale = false;
                StartGame = true;
            }
        }
        if (StartGame)
        {
            if(StepGame == 1) // Меняем местами стаканчики
            {

                correct_cup = AllCup[UnityEngine.Random.Range(0, 3)];
                print(correct_cup);
                StepGame = StepGame + 1;
            }
            else if (StepGame == 2) // Даем пользователю выбрать стаканчик
            {
                choiceCup = ChoiceCup.choiceCup;
                
                if(choiceCup != null)
                {
                    print(choiceCup);
                    StepGame = StepGame + 1;
                }
            }
            else if (StepGame == 3) // Проверяем правильность ответа
            {
                if(choiceCup == correct_cup)
                {
                    print("True");
                    
                }
                else
                {
                    print("False");
                }
                StepGame = 1;
                ChoiceCup.choiceCup = null;
            }
        }

    }

    void OnMouseDown()
    {
        animationEditScale = true;
        newScaleButton = new Vector3(0.8f, 0.8f, 1f);
        ChoiceCup.choiceCup = null;
    }

    void OnMouseUp()
    {
        newScaleButton = new Vector3(1f, 1f, 1f);
    }
}
