using System.Collections;
using System.Collections.Generic;
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

    public static Text stat = null;

    public static Vector3 def_position_cup_1;
    public static Vector3 def_position_cup_2;
    public static Vector3 def_position_cup_3;
    public static Vector3 def_position_ball;

    public static int current_record = 0;
    public static int max_record = 1;


    // Start is called before the first frame update
    void Start()
    {
        def_position_cup_1 = cup_1.transform.localPosition;
        def_position_cup_2 = cup_2.transform.localPosition;
        def_position_cup_3 = cup_3.transform.localPosition;
        def_position_ball = ball.transform.localPosition;
        pointsAtGame_TextMeshPro = GameObject.FindWithTag("GamePoints").GetComponent<TextMeshPro>();
        pointsAtGameOverSprite_TextMeshPro = GameObject.FindWithTag("Points").GetComponent<TextMeshPro>();
        stat = GameObject.FindWithTag("Stats").GetComponent<Text>();
        stat.text = max_record.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void EditRecord(int newRec)
    {
        current_record = newRec;
        if(newRec > max_record)
        {
            max_record = newRec;
        }
        stat.text = max_record.ToString();
        pointsAtGame_TextMeshPro.text = current_record.ToString();
        pointsAtGameOverSprite_TextMeshPro.text = current_record.ToString();
    }
}
