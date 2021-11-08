using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hotpotato : MonoBehaviour
{
    private int counter;
    public Color colorMat;


    void Start()
    {
        counter = Random.Range(3, 7);

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<MeshRenderer>().material.color = colorMat;


        colorMat = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    private void OnMouseDown() //al clicar en el colider del objeto actua, existe la funcion ya en unity
    {
        transform.localScale += 2 * Vector3.one;
        counter -= 1;

        if (counter <= 0)
        {
            Destroy(gameObject);
        }
    }

}
