using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{

    /*
    public int playerAge = 35;
    private float playerSpeed = 5.25f;
    public string playerName = "Layton";
    [SerializeField] private bool gameover;
    */

    public int x =5;
    public int y = 2;

    public float a = 5f;
    public float b = 2f;


    // Start is called before the first frame update
    // doble barra es comentario de una linea
    /* para comentario multilinea se abre y cierra
     * con barra asterisco
     */

    void Start()
    {
        Debug.Log($"Suma: {x} + {y} = {x + y}");
        Debug.Log("Resta: " + x + " - " + y + " = " + (x - y));
        Debug.Log($"Producto: {x} x {y} = {x*y}");
        Debug.Log($"Quocient: {x} / {y} = {x / y}");


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
    