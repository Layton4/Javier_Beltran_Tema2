using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{

    /*
    private float playerSpeed = 5.25f;
    public string playerName = "Layton";
    [SerializeField] private bool gameover;
  

    public int x =5;
    public int y = 2;

    public float a = 5f;
    public float b = 2f;

    public bool isRaining = false;
    */

    public int playerAge = 35;

    void Start()
    {
        /* Debug.Log($"Suma: {x} + {y} = {x + y}");
        Debug.Log("Resta: " + x + " - " + y + " = " + (x - y));
        Debug.Log($"Producto: {x} x {y} = {x*y}");
        Debug.Log($"Quocient: {x} / {y} = {x / y}");
        Debug.Log(string.Format("Producto: {0} * {1} = {2}", x, y, x * y));
        Debug.Log(string.Format("División: {0} / {1} = {2} ", x, y, x / y));

        if (isRaining)
        {
            Debug.Log("Lleva un paraguas");
        }
        else
        {
            Debug.Log("Hoy no llueve, suelta ese paraguas");
        }

        if (x == y)
        {
            Debug.Log("Las variables x, y son iguales");
        }
        if (x > y)
        {
            Debug.Log($"{x} es mayor que {y}");
        }
        */

        if (playerAge >= 18)
        {
            Debug.Log("Eres mayor de edad! quieres una cervesa fresca?");
        }
        else if (playerAge >= 13)
        {
            Debug.Log("Eres adolescente, teen titans, teen wolf, ben teen xd");
        }
        else
            Debug.Log("Eres un niño, como marco, en una humilde moradaaaa");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
    