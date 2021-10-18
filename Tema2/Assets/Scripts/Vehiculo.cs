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
    [SerializeField] private bool isOn = true;
 

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
        }*/

        if (isOn)
        {
            Debug.Log($"{sound}");
        }
        else if (hasSiren)
        {
            Debug.Log($"{name} hará {sound} cuando se ponga en marcha");
        }
        else
        {
            Debug.Log($"{name} no está en marcha");

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
