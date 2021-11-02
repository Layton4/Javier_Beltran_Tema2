using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PareImpar : MonoBehaviour

{
    public int num = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            num = int.Parse(GetComponent<InputField>().text);
            EsPar(num);
        }
    }

    public void EsPar(int num)
    {
        if (num%2 == 0)
        {
            Debug.Log($"El número {num} es par");
        }
        else
        {
            Debug.Log($"El número {num} es impar");
        }
    }
}
