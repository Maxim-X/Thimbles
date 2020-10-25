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

    private GameObject correct_cup;
    private GameObject choiceCup;
    GameObject[] AllCup = null;
    private SpriteRenderer button;
    private Vector3 newScaleButton = new Vector3(1f, 1f, 1f);
    private bool animationEditScale = false;
    private int StepGame = 1;
    private Vector3 cup_1_coord;
    private Vector3 cup_2_coord;

    private int count_moves = 5;

    private GameObject RandCup_1 = null;
    private GameObject RandCup_2 = null;



    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<SpriteRenderer>();
        AllCup = new GameObject[] { Cup_1,Cup_2,Cup_3 };

        cup_1_coord = new Vector3(Cup_2.transform.localPosition.x, Cup_2.transform.localPosition.y, Cup_2.transform.localPosition.z);
        cup_2_coord = new Vector3(Cup_1.transform.localPosition.x, Cup_1.transform.localPosition.y, Cup_1.transform.localPosition.z);
    }

    // Update is called once per frame
    void Update()
    {


        if (StartGame)
        {
            if (StepGame == 1) // Меняем местами стаканчики
            {

                correct_cup = AllCup[UnityEngine.Random.Range(0, 3)];

                if(RandCup_1 != null && RandCup_2 != null) {
                    RandCup_1.transform.localPosition = Vector3.Lerp(RandCup_1.transform.localPosition, cup_1_coord, Time.deltaTime + 0.1f);
                    RandCup_2.transform.localPosition = Vector3.Lerp(RandCup_2.transform.localPosition, cup_2_coord, Time.deltaTime + 0.1f);
                }



                print(Math.Round(Cup_1.transform.localPosition.x, 3) + " == " + Math.Round(cup_1_coord.x, 3));

                if (RandCup_1 == null || Math.Round(RandCup_1.transform.localPosition.x, 3) == Math.Round(cup_1_coord.x, 3))
                {
                    print(count_moves);
                    if(count_moves != 0)
                    {
                        count_moves--;

                        GameObject rand_cup_1 = AllCup[UnityEngine.Random.Range(0, 2)];
                        GameObject rand_cup_2;
                        do
                        {
                            rand_cup_2 = AllCup[UnityEngine.Random.Range(0, 3)];
                        } while (rand_cup_1 == rand_cup_2) ;


                    correct_cup = AllCup[UnityEngine.Random.Range(0, 3)];
                        cup_1_coord = new Vector3(rand_cup_2.transform.localPosition.x, rand_cup_2.transform.localPosition.y, rand_cup_2.transform.localPosition.z);
                        cup_2_coord = new Vector3(rand_cup_1.transform.localPosition.x, rand_cup_1.transform.localPosition.y, rand_cup_1.transform.localPosition.z);

                        RandCup_1 = rand_cup_1;
                        RandCup_2 = rand_cup_2;


                    }
                    else
                    {
                        StepGame = StepGame + 1;
                        count_moves = 5;
                    }

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
