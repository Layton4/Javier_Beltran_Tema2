using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class bisiesto : MonoBehaviour
{

    public int year = 2016;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            year = int.Parse(GetComponent<InputField>().text); //Get component accedemos a una componente de un cuerpo, en este caso Input Field, y de este componente accedemos al text
            EsBisiesto(year);
        }
    }

    public  void EsBisiesto(int year)
    {
        if (year % 4 == 0) //un año bisiesto es divisible entre 4
        {
            if (year % 100 == 0) //pero si es divisible entre 100 
            {
                if (year % 400 == 0) //debe ser divisible entre 400
                {
                    Debug.Log($"El año {year} es bisiesto");
                }
                else //si es divisible entre 4 y entre 100, pero no lo es de 400
                {
                    Debug.Log($"El año {year} no es bisiesto"); // no será bisiesto
                }
            }
            else //si es divisible entre 4 y no entre 100 
            {
                Debug.Log($"El año {year} es bisiesto"); //es bisiesto sin problema
            }
        }
        else //si ya no es divisible entre 4
        {
            Debug.Log($"El año {year} no es bisiesto"); //no será bisiesto
        }
    }
}
