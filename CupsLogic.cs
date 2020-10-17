using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CupsLogic : MonoBehaviour
{

    public bool isCircle = true;
    public static GameObject cup1;
    public static GameObject cup2;
    public static GameObject cup3;
    public float angle = 0; // угол 
    public static float distance = cup2.transform.position.x - cup1.transform.position.x; // дистанция между двумя соседними объектами
    public static float radius = distance / 2; // радиус
    public static float speed = 0.5f;
    private Dictionary<int, GameObject> cupsDictionary = new Dictionary<int, GameObject>
    {
        [1] = cup1,
        [2] = cup2,
        [3] = cup3
    };


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCircle)
        {
            angle += Time.deltaTime; // меняется плавно значение угла

            var x = Mathf.Cos(angle * speed) * radius;
            var y = Mathf.Sin(angle * speed) * radius;
            cup2.transform.position = new Vector2(x, y) + new Vector2(distance, 0);
            cup1.transform.position = new Vector2(x, y) - new Vector2(distance, 0);
        }
    }

    //public static GameObject[] RandomChoiceOfCup (int countOfCups)
    //{
    //    GameObject[] gameObjects = new GameObject[countOfCups];
    //    Random rnd = new Random();
    //    int[] haveCup = new int[countOfCups];

    //    int FirstChoisedCup = rnd.NextRandom(1, countOfCups);
    //    int SecondChoisedCup = rnd.NextRandom(1, countOfCups);

    //    while (SecondChoisedCup == FirstChoisedCup)
    //        SecondChoisedCup = rnd.NextRandom(1, countOfCups);


    //    return gameObjects;
    //}
}
