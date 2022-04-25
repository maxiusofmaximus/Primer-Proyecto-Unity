using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.UI;

public class MyScript : MonoBehaviour
{
    public string my_name;
    public string nombre_amigo;
    public string mensaje_bienvenida;
    public bool verdadero = true;
    public int edad;
    public int edad2;
    public int sum;
    public Text NM;
    public Button PP;
    void Start()
    {
        int sum = edad + edad2;
        mensaje_bienvenida = "Hello World, ";
        my_name = "My name is Pepe ";
        if(verdadero == true)
        {
            Debug.Log(mensaje_bienvenida + my_name + " y mi edad es " + edad);
        }
        Input.GetKeyDown("s");
        if (Input.GetKeyDown("s"))
        {
            verdadero = false;
        }
        else if(verdadero == false)
        {
            my_name += "y mi amigo se llama David";
            Debug.Log(mensaje_bienvenida + my_name + " y mi edad es " + edad2);
            Debug.Log("La suma de nuestras edades es " + sum);
        }
        NM.text = my_name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnJump()
    {

    }
}
