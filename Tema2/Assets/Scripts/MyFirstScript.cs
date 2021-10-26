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

    
   

    public int playerAge = 35;
    public int x = 5;
    public int y = 2;
    public bool isRaining = false;
    public bool isCold = false;
    public int zi = 6%2;

    [SerializeField] private int año;
     */

    [SerializeField] private int posicion1a8 = 0;
    public int num1;
    public int num2;

    void Start()
    {

        Debug.Log(producto(2, 6));
        Debug.Log(producto(num1, num2));

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

        if (x == 2 && y <= 5) // la x vale 2 o la y es menor igual que 5
        {
            Debug.Log($"{x} tiene valor 2 y {y} es menor o igual que 5");
        }
        else if (x == 3 || y > 6) // x vale 3 o la y es mayor que 6
        {
            Debug.Log($"{x} tiene valor 3 o {y} es mayor que 2");
        }
        else if (x > 0 && y == 2) //x es mayor que 0 y la y vale 2
        {
            Debug.Log($"{x} es positivo y la variable y vale {y}");
        }
        else
            Debug.Log("No es ningun caso previsto jajaja");
         */
        /*
                if (isRaining)
                {
                    if (isCold)
                    {
                        Debug.Log("Lleva paraguas y sudadera");
                    }
                    else
                    { 
                        Debug.Log("Lleva paraguas");
                    }
                }
                else
                {
                    if (isCold)
                    {
                        Debug.Log("Llevate una sudadera");
                    }
                    else
                    {
                        Debug.Log("No pases un buen día, pasa un gran día! :)");
                    }
                }

                Debug.Log($"Estamos en el año {año}"); 

                if (año%4 == 0) //divisible entre 4
                {
                    if (año%100 == 0) //Si es divisible entre 100 
                    {
                        if (año%400 == 0) //tiene que ser divisible entre 400
                        {
                            Debug.Log($"Este año es bisiesto");
                        }
                    }
                    else //si no es divisible entre 100 pero si de 4
                    {
                        Debug.Log($"Este año es bisiesto");
                    }

                }
                else //si ya no es divisible entre 4 ya no es bisiesto
                {
                    Debug.Log("No estamos en un año bisiesto");
                }
             

        Debug.Log(transform.position);

        transform.position = new Vector3(0,0,0);
        if (posicion1a8 == 0)
        {
            transform.position = Vector3.zero;
        }
        if (posicion1a8 == 1)
        {
            transform.position = Vector3.one;
        }
        if (posicion1a8 == 2)
        {
            transform.position = Vector3.up;
        }
        if (posicion1a8 == 3)
        {
            transform.position = Vector3.down;
        }
        if (posicion1a8 == 4)
        {
            transform.position = Vector3.right;
        }
        if (posicion1a8 == 5)
        {
            transform.position = Vector3.left;
        }
        if (posicion1a8 == 6)
        {
            transform.position = Vector3.forward;
        }
        if (posicion1a8 == 7)
        {
            transform.position = Vector3.back;
        }
         */


    }



    /*  if (Input.GetKeyDown(KeyCode.D)) //Moverse a la derecha cuando pulsamos la flecha derecha
        {
            transform.position += Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.A)) //Moverse a la izquierda cuando pulsamos la flecha izquierda
        {
            transform.position += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position += Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position += Vector3.down;
        }
    
      if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation *= Quaternion.Euler(0, 10, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation *= Quaternion.Euler(0, -10, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.rotation *= Quaternion.Euler(10, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.rotation *= Quaternion.Euler(-10, 0, 0);
        }*/


    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position);

        movementToDirection(KeyCode.D, Vector3.right);
        movementToDirection(KeyCode.A, Vector3.left);
        movementToDirection(KeyCode.W, Vector3.forward);
        movementToDirection(KeyCode.S, Vector3.back);
        movementToDirection(KeyCode.E, Vector3.up);
        movementToDirection(KeyCode.Q, Vector3.up);

       

        movementToRotation(KeyCode.RightArrow, Vector3.up);
        movementToRotation(KeyCode.LeftArrow, Vector3.down);
        movementToRotation(KeyCode.UpArrow, Vector3.right);
        movementToRotation(KeyCode.DownArrow, Vector3.left);

        movementToEscale(KeyCode.X, Vector3.right);
        movementToEscale(KeyCode.Y, Vector3.up);
        movementToEscale(KeyCode.Z, Vector3.forward);

    }

    public void movementToDirection(KeyCode key, Vector3 direction)
    {
        if (Input.GetKeyDown(key)) //Moverse a la derecha cuando pulsamos la flecha derecha
        {
            transform.position += direction;
        }
    }
    public void movementToEscale(KeyCode key, Vector3 direction)
    {
        if (Input.GetKeyDown(key))
        {
            transform.localScale += direction;
        }
    }
    public void movementToRotation(KeyCode key, Vector3 direction)
    {
        if (Input.GetKeyDown(key))
        {
            transform.rotation *= Quaternion.Euler(10 * direction);
        }
 
    }

    public string producto(int a, int b)
    {
 
        return $"{a} x {b} = {a * b}";
    }
}
    