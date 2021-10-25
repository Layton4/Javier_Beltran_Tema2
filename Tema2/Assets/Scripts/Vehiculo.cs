using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehiculo : MonoBehaviour
{
    //Variable que guarda el sonido del vehículo
    [SerializeField] private string sound = "¡Brum Brum!";
    [SerializeField] private string name; //variable para nombrar y guardar el nombre del coche y la ambulancia
    [SerializeField] private int numberWheels = 4; //aquí guardaremos el numero de ruedas del vehiculo

    [SerializeField] private bool hasSiren = false; // variable para indicar si tiene sirena
    [SerializeField] private bool isOn = true; //esta variable indica si el vehiculo está en marcha

    [SerializeField] private float gasoline;

    public string hello;



    // Start is called before the first frame update
    void Start()
    {
        /* Debug.Log($"{name} tiene {numberWheels} ruedas y hace {sound}");

         if (hasSiren) //operador que comprueba si el vehiculo tiene sirena y lo indica en caso afirmativo
         {
             Debug.Log($"{name} tiene sirena");
         }
         else
         {
             Debug.Log($"{name} no tiene sirena tonto, jaja salu2");
         }

         if (isOn) //si está en marcha el vehiculo
         {
             Debug.Log($"{sound}"); //muestra el sonido que hace el vehiculo
         }
         else if (hasSiren) //si no está en marcha pero tiene sirena
         {
             Debug.Log($"{name} hará {sound} cuando se ponga en marcha"); //nos avisa el sonido que hará al arrancar
         }
         else //en cualquier otro caso, o sea que no está en marcha y no tiene sirena
         {
             Debug.Log($"{name} no está en marcha"); //avisa que no está en marcha

         }
       
        if (isOn)
        {
            if (gasoline < 10)
            {
                Debug.Log($"¡A {name} le queda poca gasofa, necesitamos repostar");
            }
            if (hasSiren)
            {
                Debug.Log(sound);
            }
            else
            {
                Debug.Log($"{name} no tiene sirena");
            }
        }
        else
        {
            Debug.Log($"{name} no está en marcha");
        
         */
        hello = GetHello();

        HelloWorld();
        //Debug.Log(hello);
        Debug.Log(GetHello());



    }

    // Update is called once per frame
    void Update()
    {
        if (isOn)
        {
            if (Input.GetKeyDown(KeyCode.D)) //Moverse a la derecha cuando pulsamos la flecha derecha
            {
                transform.position += Vector3.right;
            }
            if (Input.GetKeyDown(KeyCode.A)) //Moverse a la izquierda cuando pulsamos la flecha izquierda
            {
                transform.position += Vector3.left;
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.position += Vector3.forward;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.position += Vector3.back;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.rotation *= Quaternion.Euler(0, 10, 0);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.rotation *= Quaternion.Euler(0, -10, 0);
            }
        }
    }
    public void HelloWorld()
    {
        Debug.Log("¡Hola mundo!");
    }
    public string GetHello()
    {
        return "Holi wapi";
    }
}
