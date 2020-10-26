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

    public static bool StartGame = false;

    private GameObject correct_cup = null;
    private GameObject choiceCup;
    GameObject[] AllCup = null;
    private SpriteRenderer button;
    private Vector3 newScaleButton = new Vector3(1f, 1f, 1f);
    private bool animationEditScale = false;
    private int StepGame = 1;
    private Vector3 cup_1_coord;
    private Vector3 cup_2_coord;

    private int count_moves = 5;
    private int count_moves_def = 5;

    private GameObject UseCup_1 = null;
    private GameObject UseCup_2 = null;

    private float x_pre_1; // Предыдущий x передвижения
    private float x_pre_2; // Предыдущий x передвижения



    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<SpriteRenderer>();
        AllCup = new GameObject[] { Cup_1,Cup_2,Cup_3 };

        cup_2_coord = new Vector3(Cup_2.transform.localPosition.x, Cup_2.transform.localPosition.y, Cup_2.transform.localPosition.z);
        cup_1_coord = new Vector3(Cup_1.transform.localPosition.x, Cup_1.transform.localPosition.y, Cup_1.transform.localPosition.z);
    }

    // Update is called once per frame
    void Update()
    {


        if (StartGame)
        {
            if (StepGame == 1) // Меняем местами стаканчики
            {

                if(correct_cup == null)
                {
                    correct_cup = AllCup[UnityEngine.Random.Range(0, 3)]; // правельный стаканчик
                }


                if(UseCup_1 == null && UseCup_2 == null)
                {
                    GameObject rand_cup_1 = AllCup[UnityEngine.Random.Range(0, 3)];
                    GameObject rand_cup_2;
                    do
                    {
                        rand_cup_2 = AllCup[UnityEngine.Random.Range(0, 3)];
                    } while (rand_cup_1 == rand_cup_2);


                    cup_1_coord = new Vector3(rand_cup_1.transform.localPosition.x, rand_cup_1.transform.localPosition.y, rand_cup_1.transform.localPosition.z);
                    cup_2_coord = new Vector3(rand_cup_2.transform.localPosition.x, rand_cup_2.transform.localPosition.y, rand_cup_2.transform.localPosition.z);

                    UseCup_1 = rand_cup_1;
                    UseCup_2 = rand_cup_2;

                    x_pre_1 = UseCup_1.transform.localPosition.x;
                    x_pre_2 = UseCup_2.transform.localPosition.x;
                }


                if(UseCup_1 != null && UseCup_2 != null) { // перемещаем стаканчики
                    UseCup_1.transform.localPosition = Vector3.Lerp(UseCup_1.transform.localPosition, cup_2_coord, Time.deltaTime + 0.1f);
                    UseCup_2.transform.localPosition = Vector3.Lerp(UseCup_2.transform.localPosition, cup_1_coord, Time.deltaTime + 0.1f);
                }


                if(x_pre_1 == UseCup_1.transform.localPosition.x)
                {
                    if (count_moves != 0)
                    {
                        count_moves--;

                        UseCup_1 = null;
                        UseCup_2 = null;

                    }
                    else
                    {
                        StepGame = StepGame + 1;
                    }
                }
                else
                {
                    x_pre_1 = UseCup_1.transform.localPosition.x;
                }

            }
            else if (StepGame == 2) // Даем пользователю выбрать стаканчик
            {
                choiceCup = ChoiceCup.choiceCup;

                if (choiceCup != null)
                {
                    print(choiceCup);
                    StepGame = StepGame + 1;
                }
            }
            else if (StepGame == 3) // Проверяем правильность ответа
            {
                if (choiceCup == correct_cup)
                {
                    print("True");

                }
                else
                {
                    print("False");
                }
                correct_cup = null;
                count_moves = count_moves_def;
                StepGame = 1;
                ChoiceCup.choiceCup = null;
            }
        }
        

        if (animationEditScale)
        {
            button.transform.localScale = Vector3.Lerp(transform.localScale, newScaleButton, Time.deltaTime + 0.1f);
            if (Math.Round(button.transform.localScale.x, 2) == 0.99)
            {
                animationEditScale = false;
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
