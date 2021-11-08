using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumber : MonoBehaviour
{

    private int randNum;
    public int myNum = 4;
    private int contador = 1;

    // Start is called before the first frame update
    void Start()
    {
        randNum = Random.Range(0, 11);
        Debug.Log("Voy a pensar un numero aleatorio entre el 0 y el 10, te reto a adivinarlo!!");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            myNum = int.Parse(GetComponent<InputField>().text);

            ComparetoRandom(myNum);
        }
       
        
    }
    public void ComparetoRandom(int usernum)
    {
        if (usernum > randNum)
        {
            Debug.Log($"El numero que estoy pensando es menor a {usernum}");
            contador += 1;
        }
        else if (usernum < randNum)
        {
            Debug.Log($"El numero que estoy pensando es mayor a {usernum}");
            contador += 1;
        }
        else
        {
            Debug.Log($"¡ESO ES! estaba pensando en el número {usernum}");
            Debug.Log($"Lo has acertado en {contador} intentos");
            Debug.Log($"Juguemos otra vez! he pensado un nuevo numero aleatorio. ¿Cual será?");
            randNum = Random.Range(0, 11);
            contador = 1;
        }
    }
}
