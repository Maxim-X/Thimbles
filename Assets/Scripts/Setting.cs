﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    public static bool pause = false;
    public static bool StartGame = false;

    [SerializeField] private GameObject cup_1 = null;
    [SerializeField] private GameObject cup_2 = null;
    [SerializeField] private GameObject cup_3 = null;
    [SerializeField] private GameObject ball = null;

    // количество очков, отображаемое во время игры
    public static TextMeshPro pointsAtGame_TextMeshPro = null;
    // Текст в диалоговом окне проигрыша с количеством очков
    public static TextMeshPro pointsAtGameOverSprite_TextMeshPro = null;
    // Текст с рекордами на начальном экране
    public static TextMeshPro recordsNumbersSprite_TextMeshPro = null;

    // Нынешний рекорд
    public static TextMeshPro stat = null;

    public static bool Vibrate = true;

    public static Vector3 def_position_cup_1;
    public static Vector3 def_position_cup_2;
    public static Vector3 def_position_cup_3;
    public static Vector3 def_position_ball;

    public static int current_record = 0;

    // Здесь хранится максимальный рекорд
    public static int max_record = 0;

    public static float speed_cup = 0.25f;
    public static int cup_moves = 5;
    public static int cup_moves_def = 5;

    // Текст, который будем выводить на экран
    public static string recordText = "0\n0\n0\n0\n0\n";
    
    // Start is called before the first frame update
    void Start()
    {
        def_position_cup_1 = cup_1.transform.localPosition;
        def_position_cup_2 = cup_2.transform.localPosition;
        def_position_cup_3 = cup_3.transform.localPosition;
        def_position_ball = ball.transform.localPosition;
        pointsAtGame_TextMeshPro = GameObject.FindWithTag("GamePoints").GetComponent<TextMeshPro>();
        pointsAtGameOverSprite_TextMeshPro = GameObject.FindWithTag("Points").GetComponent<TextMeshPro>();
        stat = GameObject.FindWithTag("Stats").GetComponent<TextMeshPro>();
        recordsNumbersSprite_TextMeshPro = GameObject.FindWithTag("RecordsList").GetComponent<TextMeshPro>();
        stat.text = max_record.ToString();

        if (recordText != "0\n0\n0\n0\n0\n")
            recordText = PlayerPrefs.GetString("RecordsList");

        recordsNumbersSprite_TextMeshPro.text = recordText;
    }

    // Update is called once per frame
    void Update()
    {
        if (current_record > max_record)
        {
            PlayerPrefs.SetInt("maxrecord", current_record);
            PlayerPrefs.Save();
            Debug.Log("Save");
        }
        max_record = PlayerPrefs.GetInt("maxrecord");
    }

    public static void EditRecord(int newRec)
    {
        current_record = newRec;
        if(newRec > max_record)
        {
            max_record = newRec;
        }
        EditSpeedCup();
        stat.text = max_record.ToString();
        EditmovesCup();
        pointsAtGame_TextMeshPro.text = current_record.ToString();
        pointsAtGameOverSprite_TextMeshPro.text = current_record.ToString();
    }

    public static void SaveRecord()
    {
        print("Текущее количество очков: " + current_record);
        print("Максимальный рекорд: " + max_record);

        // Сортируем и удаляем лишние 
        if (current_record > max_record)
        {
            // Сохраняем рекорд игрока 
            recordText = current_record + "\n" + recordText;
            recordText = recordText.Remove(6, 2);
            PlayerPrefs.SetString("RecordsList", recordText);
            PlayerPrefs.Save();
            Debug.Log("Records Saved");

            recordsNumbersSprite_TextMeshPro.text = recordText;
        }
    }

    public static void EditSpeedCup()
    {
        if (current_record % 5 == 0)
        {
            speed_cup = (float)(0.25 + ((current_record / 5) * 0.02f));
        }

    }
    public static void EditmovesCup()
    {
        if (current_record % 3 == 0)
        {
            cup_moves = (cup_moves_def + (current_record / 3));
        }

    }
}
