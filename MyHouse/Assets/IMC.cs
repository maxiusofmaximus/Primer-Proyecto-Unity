using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMC : MonoBehaviour
{
    private string _name = "Pepe";
    public string change_name;
    public static float _Kilo;
    public static float _Alto;
    private float _IMC;

    void Start()
    {
        _Alto = _Alto * _Alto;
        Set_IMC(_Kilo / _Alto);
        if(_IMC < 15)
        {
            Debug.Log("Delgadez muy severa");
        }
        else if (_IMC < 15.9 && _IMC > 15)
        {
            Debug.Log("Delgadez severa");
        }
        else if (_IMC < 18.4 && _IMC > 16)
        {
            Debug.Log("Delgadez");
        }
        else if (_IMC < 24.9  && _IMC > 18.5)
        {
            Debug.Log("Peso saludable");
        }
        else if (_IMC < 29.9 && _IMC > 25)
        {
            Debug.Log("Sobrepeso");
        }
        else if (_IMC < 34.9 && _IMC > 30)
        {
            Debug.Log("Obesidad moderada");
        }
        else if (_IMC < 39.9 && _IMC > 35)
        {
            Debug.Log("Obesidad severa");
        }
        else if (_IMC < 100 && _IMC > 40)
        {
            Debug.Log("Obesidad muy severa (Obesidad mórvida)");
        }
        else
        {
            Debug.Log("Error");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public string Set_name(string _str)
    {
        _name = _str;
        return _name;
    }
    public void Get_name()
    {
        _name = _name;
    }
    public float Set_IMC(float imc)
    {
        _IMC = imc;
        return _IMC;
    }
    public void Get_IMC()
    {
        _IMC = _IMC;
    }

    public void Change_name()
    {
        change_name = Set_name(change_name);
    }
}
